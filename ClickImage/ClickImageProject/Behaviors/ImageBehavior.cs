using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Services;
using WaveEngine.ImageEffects;


namespace ClickImageProject.Behaviors
{
    class ImageBehavior : Behavior
    {
        // we need Transform2D to check size&position
        [RequiredComponent]
        private Transform2D _transform;

        private Entity _cameraEntity;
        private Input _input;
        private bool _changed = false;

        public ImageBehavior(Entity cameraEntity)
        {
            _cameraEntity = cameraEntity;
        }

        protected override void Update(TimeSpan gameTime)
        {

            var touch = _input.TouchPanelState;

            if (touch.Count > 0)
            {
                // taped?
                if (touch[0].State == WaveEngine.Common.Input.TouchLocationState.Pressed)
                {
                    // check position
                    var pos = touch[0].Position;

                    if (pos.X < _transform.LocalX+_transform.Rectangle.Width
                        && pos.X > _transform.LocalX
                        && pos.Y < _transform.LocalY+_transform.Rectangle.Height
                        && pos.Y > _transform.LocalY)
                    {
                        if (!_changed)
                        {
                            this._cameraEntity.AddComponent(ImageEffects.Pixelate());
                            _changed = true;
                        }
                    }
                }
            }
        }

        protected override void Initialize()
        {
            base.Initialize();

            _input = WaveServices.Input;
        }
    }
}
