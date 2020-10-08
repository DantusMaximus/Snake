using System;
using System.Threading;
namespace Snake
{
    class UserInput
    {
        static char lastInput = 'd';
        static public void Read(Snake snake)
        {
            var startTime = DateTime.Now;
            char input = lastInput;
            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < 400)
            {
                if (Console.KeyAvailable)
                {
                        input = Console.ReadKey(true).KeyChar;
                }
                else
                {
                    if(snake.snakeBody.Contains((snake.Head.Item1-1, snake.Head.Item2)) && input == 'a'){
                        input = lastInput;
                        continue;
                    }
                    if(snake.snakeBody.Contains((snake.Head.Item1+1, snake.Head.Item2)) && input == 'd'){
                        input = lastInput;
                        continue;
                    }
                    if(snake.snakeBody.Contains((snake.Head.Item1, snake.Head.Item2-1)) && input == 'w'){
                        input = lastInput;
                        continue;
                    }
                    if(snake.snakeBody.Contains((snake.Head.Item1, snake.Head.Item2+1)) && input == 's'){
                        input = lastInput;
                        continue;
                    }
                if(!(input == 'a' || input == 'w' || input == 's' || input == 'd')){
                    input = lastInput;
                    continue;
                }
                lastInput = input;
            }
        }
        }
        static public char LastInput
        {
            get {return lastInput;}
            set{lastInput = value;}
        }
}
}