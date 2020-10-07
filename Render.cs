using System;
namespace Snake{
    class Render{
        static public void Print(Field field, Snake snake){
            Console.WriteLine();
            EndRow(field.Width+2);
            for(int y = 0; y < field.Heigth; y++){
                Row(field, y, snake);
            }
            EndRow(field.Width+2);
        }
        static void Row(Field field, int y, Snake snake){
            Console.Write("#");
            for(int x = 0; x < field.Width; x ++){
                Console.ForegroundColor = ConsoleColor.White;
                if(snake.snakeBody.Contains((x,y)) || (snake.Head.Item1 == x && snake.Head.Item2 == y)){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                    continue;
                }
                else if(field.Fruit.Item1 == x && field.Fruit.Item2 == y){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    continue;
                }
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("#");
        }
        static void EndRow(int width){
            for(int i = 0; i<width; i++){
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}