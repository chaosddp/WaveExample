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
        


        protected override void Initialize()
        {
            base.Initialize();

            _input = WaveServices.Input;
        }

        protected override void Update(TimeSpan gameTime)
        {
            _transform.X = _input.MouseState.X;
            _transform.Y = _input.MouseState.Y;
        }
    }
}
