using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to draw all of the actors in the game.
    /// </summary>
    public class HandleOffScreenAction : Action
    {

        public HandleOffScreenAction()
        {
        }
        
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
           foreach(Ball ball in cast["balls"])
            {
            // ball.SetVelocity(new Point(6, -6));

                if (ball.GetX() >= Constants.MAX_X - Constants.BALL_WIDTH)
                {
                    ball.bounceHorizontal();
                }
                if (ball.GetX() <= 0)
                {
                    ball.bounceHorizontal();
                }
                if (ball.GetY() <= 0)
                {
                    ball.bounceVertical();
                }
            }
        }

    }
}
