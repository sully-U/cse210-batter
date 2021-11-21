using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// Class to handle the interaction between actors (brick and ball, ball and paddle)
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();
        int _points = 0;

        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        /// <summary>
        /// Overrides the action of the actors to move correctly
        /// </summary>
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> bricksToRemove = new List<Actor>();
            List<Actor> balls = cast["balls"];
            Actor paddle = cast["paddle"][0]; 
            List<Actor> bricks = cast["bricks"];

            for (int i = 0; i < balls.Count; i++)
            {
            Ball ball = (Ball)balls[i];
            if (_physicsService.IsCollision(paddle, ball))
                {
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    ball.bounceVertical();
                    _points++;
                }
                
                foreach (Actor actor in bricks)
                {
                    Brick brick = (Brick)actor;
                    
                    if (_physicsService.IsCollision(ball, brick))
                    {
                        bricksToRemove.Add(brick);
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        ball.bounceVertical();
                    }
                    if (ball.GetX() == brick.GetRightEdge() && ball.GetY() >= brick.GetTopEdge() && ball.GetY()<=brick.GetBottomEdge())
                    {
                        bricksToRemove.Add(brick);
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        ball.bounceHorizontal();
                    }
                    if (ball.GetX() == (brick.GetLeftEdge()-Constants.BALL_WIDTH) && ball.GetY() >= brick.GetTopEdge() && ball.GetY()<=brick.GetBottomEdge())
                    {
                        bricksToRemove.Add(brick);
                        _audioService.PlaySound(Constants.SOUND_BOUNCE);
                        ball.bounceHorizontal();
                    }
                }

            }

            /// <summary>
            /// Keeps track of ball and paddle interaction, once they have made contact 10 times, a new ball is added. 
            /// </summary>
    
            if (_points == 10)
            {
                Ball ball = new Ball(400, 520);
                cast["balls"].Add(ball);
                _points = 0;
            }
            /// <summary>
            /// Removes the brick from the screen
            /// </summary>
            foreach (Brick brick in bricksToRemove)
            {
                cast["bricks"].Remove(brick);
            }  
        }


    }
}