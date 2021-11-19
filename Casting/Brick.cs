using System;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Brick : Actor
    {

        public Brick(int x, int y)
        {
            SetImage(Constants.IMAGE_BRICK);

            Point position = new Point(x, y);
            SetPosition(position);
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
        }
    }
}