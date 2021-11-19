using System;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp
{
    /// <summary>
    /// Base class for all actors in the game.
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
            public void bounceHorizontal()
            {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(-dx, dy);
            }

            public void bounceVertical()
            {
                int dx = _velocity.GetX();
                int dy = _velocity.GetY();

                _velocity = new Point(dx, -dy);
            }

    }
}