#region Using Statements
using Share;
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Animation;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
#endregion

namespace LoadAnimationProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {            // Create a 2D camera
            var camera2D = new FixedCamera2D("Camera2D") { }; // Transparent background need this clearFlags.
            EntityManager.Add(camera2D);

            var animation = Animation2D.Create<TexturePackerGenericJson>("Content/Animations/running_bot.json");
            
            animation.Add("run", new SpriteSheetAnimationSequence()
            {
                First = 0,
                Length = 10,
                FramesPerSecond = 15
            });

            
            // Draw a simple sprite
            Entity sprite = new Entity()
                .AddComponent(new Transform2D())
                .AddComponent(new Sprite("Content/Animations/running_bot"))
                .AddComponent(new AnimatedSpriteRenderer())
                .AddComponent(animation);

            this.EntityManager.Add(sprite);

            animation.Play(true);
        }

        protected override void Start()
        {
            base.Start();

            // This method is called after the CreateScene and Initialize methods and before the first Update.
        }
    }
}
