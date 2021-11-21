using System;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp
{
    /// <summary>
    /// Class for the ball actor
    /// </summary>
    public class Ball : Actor
    {
        public Ball(int x, int y)
        {
            SetImage(Constants.IMAGE_BALL);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetVelocity(new Point(6, -6));
            MoveNext();
        }
            /// <summary>
            /// Handle the horizontal change of direction of thr ball
            /// </summary>
            public void bounceHorizontal()
            {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(-dx, dy);
            }
            /// <summary>
            /// Handle the vertical change of direction of thr ball
            /// </summary>
            public void bounceVertical()
            {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(dx, -dy);
            }

    }
}