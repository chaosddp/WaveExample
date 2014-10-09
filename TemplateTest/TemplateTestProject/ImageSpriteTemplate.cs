using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Components.Graphics2D;

namespace TemplateTestProject
{
    public class ImageSpriteTemplate : Template
    {
        public ImageSpriteTemplate() : base("Image Sprite") { }

        public override Entity Create()
        {
            var entity = new Entity();

            entity.AddComponent(new Transform2D())
                .AddComponent(new Sprite("Content/ein"))
                .AddComponent(new SpriteRenderer(DefaultLayers.Opaque));

            return entity;
        }
    }
}
