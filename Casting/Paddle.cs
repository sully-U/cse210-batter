using System;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// Class for the paddle actor
    /// </summary>
    public class Paddle : Actor
    {
        public Paddle(int x, int y)
        {
            SetImage(Constants.IMAGE_PADDLE);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.PADDLE_WIDTH);
            SetHeight(Constants.PADDLE_HEIGHT);
        }
        // public void rightBoundary()
        // {
        //         int dx = _velocity.GetX();
        //         int dy = _velocity.GetY();

        //         _velocity = new Point(dx, dy);
        //         _position = new Point (Constants.MAX_X-1-Constants.PADDLE_WIDTH, GetY());
        // }
        // public void leftBoundary()
        // {
        //         int dx = _velocity.GetX();
        //         int dy = _velocity.GetY();

        //         _velocity = new Point(dx, dy);
        //         _position = new Point (1, GetY());
        // }


    }
}