using System;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// Base class for all actors in the game.
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
    }
}