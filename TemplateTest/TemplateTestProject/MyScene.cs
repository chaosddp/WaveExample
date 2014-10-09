#region Using Statements
using Share;
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

namespace TemplateTestProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            // Create a 2D camera
            var camera2D = new FixedCamera2D("Camera2D") { }; // Transparent background need this clearFlags.
            EntityManager.Add(camera2D);

            EntityManager.Add(TemplateManager.Instance.Create("Image Sprite"));
        }

        void InitTemplate()
        {
            TemplateManager.Instance.Add<ImageSpriteTemplate>();
        }

        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
