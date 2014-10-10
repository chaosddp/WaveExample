#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Gestures;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Physics2D;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
#endregion

namespace ClickImageProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            //Insert your scene definition here.

            var camera = new FixedCamera2D("camera");

            EntityManager.Add(camera);


            var imgTouchComp = new TouchGestures();
            imgTouchComp.TouchTap += (sender, e) =>
            {
                // what should we do when being touched£¿
                System.Diagnostics.Debug.WriteLine("Yes, you clicked on me.");
            };

            var img = new Entity()
                .AddComponent(new Transform2D()) // need this for touch gestures and drawing
                .AddComponent(new RectangleCollider()) // need this for touch gestures
                .AddComponent(new Sprite("Content/ein"))
                .AddComponent(new SpriteRenderer(DefaultLayers.Opaque))
                .AddComponent(imgTouchComp);
           
            EntityManager.Add(img);

        }


        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
