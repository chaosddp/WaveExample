using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Services;

namespace MoveImageProject.Behaviors
{
    public class ImageBehavior : Behavior
    {
        [RequiredComponent]
        private Transform2D _transform=null;

        private double _lastInterval = 0;

        private double _interval = 50;

        private float _rightEdge;
        private float _leftEdge;

        private float _speed = 10;

        protected override void Initialize()
        {
            base.Initialize();

            _rightEdge = WaveServices.ViewportManager.RightEdge;
            _leftEdge = WaveServices.ViewportManager.LeftEdge;
        }

        protected override void Update(TimeSpan gameTime)
        {

            _lastInterval += gameTime.Milliseconds;

            if (_lastInterval > _interval)
            {
                _lastInterval -= _interval;
                _transform.X += _speed;
            }

            if (_transform.LocalX + _transform.Rectangle.Width > _rightEdge
                || _transform.LocalX < _leftEdge)
            {
                _speed = -_speed;
            }
        }
    }
}
