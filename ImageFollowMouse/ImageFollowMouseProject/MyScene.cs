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

namespace ImageFollowMouseProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            //Insert your scene definition here.

            var camera = new FixedCamera2D("camera");

            this.EntityManager.Add(camera);

            var img = new Entity()
                .AddComponent(new Transform2D() { Origin = new Vector2(0.5f, 0.5f), XScale = 0.5f, YScale = 0.5f })
                .AddComponent(new Sprite("Content/ein"))
                .AddComponent(new SpriteRenderer(DefaultLayers.Opaque))
                .AddComponent(new Share.Behaviors.MoveToPointerBehavior(5f));

            this.EntityManager.Add(img);
        }

        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
