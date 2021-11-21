using System;

namespace cse210_batter_csharp.Casting
{
    /// <summary>
    /// Class for the brick actor
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