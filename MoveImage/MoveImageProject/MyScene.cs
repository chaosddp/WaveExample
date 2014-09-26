#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
#endregion

namespace MoveImageProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            //Insert your scene definition here.

            var camera = new FixedCamera2D("camera");

            this.EntityManager.Add(camera);

            var img = new Entity()
                .AddComponent(new Transform2D())
                .AddComponent(new Sprite("Content/ein"))
                .AddComponent(new SpriteRenderer(DefaultLayers.Opaque))
                .AddComponent(new Behaviors.ImageBehavior());

            this.EntityManager.Add(img);
        }

        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
