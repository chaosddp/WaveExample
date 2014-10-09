#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Components.UI;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
using WaveEngine.Framework.UI;
#endregion

namespace RenderTextProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
    

            // Create a 2D camera
            var camera2D = new FixedCamera2D("Camera2D") { }; 
            EntityManager.Add(camera2D);


            // we use this UI control to render text
            var text = new TextBlock() { 
             Text = "Hello, WaveEngine\nAnd next line?",
             Margin = new Thickness(20, 20, 0, 0),
             HorizontalAlignment = HorizontalAlignment.Center, // make it top-center
              VerticalAlignment = VerticalAlignment.Top
            };

            this.EntityManager.Add(text);
        }

        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
