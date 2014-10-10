using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyTween;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;

namespace TweenImageProject
{
    public class TweenBehavior : Behavior
    {
        [RequiredComponent]
        private Transform2D _transform;

        private FloatTween _tween;

        protected override void Initialize()
        {
            base.Initialize();

            _tween = new FloatTween();

            _tween.Start(_transform.X, 500f, 10000f, ScaleFuncs.Linear);
        }

        

        protected override void Update(TimeSpan gameTime)
        {
            _tween.Update((float)gameTime.TotalMilliseconds);

            _transform.X = _tween.CurrentValue;
        }
    }
}
