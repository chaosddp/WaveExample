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

namespace LoadImageProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            //Insert your scene definition here.

            var camera2d = new FixedCamera2D("Camera2D") { 
             ClearFlags = ClearFlags.DepthAndStencil
            };

            EntityManager.Add(camera2d);

            var img = new Entity()
                .AddComponent(new Transform2D())
                .AddComponent(new Sprite("Content/ein"))
                .AddComponent(new SpriteRenderer(DefaultLayers.Opaque));

            this.EntityManager.Add(img);

        }

        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
