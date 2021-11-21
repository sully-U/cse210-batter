using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// Handle the actors to stay on screen
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        
        public HandleOffScreenAction()
        {
        }
        /// <summary>
        /// Overrides the action of the balls to bounce correctly off the sides of the screen.
        /// </summary>
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
           foreach(Ball ball in cast["balls"])
            {
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
            // foreach (Paddle paddle in cast["paddle"])
            // {
            //     if (paddle.GetX()>= Constants.MAX_X-Constants.PADDLE_WIDTH)
            //     {
            //         paddle.rightBoundary();
            //     }
            //     if (paddle.GetX()<=0)
            //     {
            //         paddle.leftBoundary();
            //     } 
            // }
        }

    }
}
