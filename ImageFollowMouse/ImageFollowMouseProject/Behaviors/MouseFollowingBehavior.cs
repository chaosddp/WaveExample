using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveEngine.Common.Input;
using WaveEngine.Common.Math;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Services;

namespace ImageFollowMouseProject.Behaviors
{
    public class MouseFollowingBehavior : Behavior
    {
        [RequiredComponent]
        private Transform2D _transform = null;

        private Input _input;

        private float _speed = 10f;

        protected override void Initialize()
        {
            base.Initialize();

            _input = WaveServices.Input;
        }

        protected override void Update(TimeSpan gameTime)
        {
            var mousePosition = new Vector2(_input.MouseState.X, _input.MouseState.Y);

            var currentPosition = new Vector2(_transform.X, _transform.Y);

            var dir = mousePosition - currentPosition;

            if (dir.Length() < 10.0f) return;

            // calculate the radian of the mouse and current position
            var angle = (float)(Math.Atan2(dir.Y, dir.X));

            // calculate speed on x/y axis
            _transform.X += (float)Math.Cos((double)angle) * _speed;
            _transform.Y += (float)Math.Sin((double)angle) * _speed;
        }
    }
}
