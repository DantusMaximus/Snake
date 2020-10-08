using System;

namespace Snake
{
    class Game
    {
        
        static void Main(string[] args)
        {
            Snake snake = new Snake(Int32.Parse(args[0]), Int32.Parse(args[1]), Int32.Parse(args[2]));
            Field field = new Field(Int32.Parse(args[0]), Int32.Parse(args[1]));
            while (GameOngoing(snake, field))
            {
                Render.Print(field, snake);
                UserInput.Read(snake);
                    if (snake.Head == field.Fruit)
                {
                    snake.Eat();
                    field.GenerateFruit();
                }
                else{
                     snake.Move();
                }     
            }
            if(snake.Length + 1 >= field.Width*field.Heigth){
                Console.WriteLine("So you found a Hamiltonian cycle. Impressive!");
            }
            else{
                Console.WriteLine($"Game over! You got {snake.Score} points");
            }
        }
        static bool GameOngoing(Snake snake, Field field)
        {
            if (snake.Head.Item1 >= field.Width || snake.Head.Item1 < 0 || snake.Head.Item2 >= field.Heigth || snake.Head.Item2 < 0)
            {//checks if snake has collided with boundary
                return false;
            }
            if (snake.snakeBody.Contains((snake.Head.Item1, snake.Head.Item2)))
            {//checks if snake bites itself
                return false;
            }
            return true;
        }
    }
}
