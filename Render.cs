using System;
namespace Snake{
    class Render{
        static public void Print(Field field, Snake snake){
            Console.Clear();
            string text = "";
            text += "\n"; //Console.WriteLine();
            text += EndRow(field.Width+2);
            for(int y = 0; y < field.Heigth; y++){
                text += Row(field, y, snake);
            }
            text += EndRow(field.Width+2);
            Console.Write(text);
        }
        static string Row(Field field, int y, Snake snake){
            string text = "#"; //Console.Write("#");
            for(int x = 0; x < field.Width; x ++){
                //Console.ForegroundColor = ConsoleColor.White;
                if(snake.snakeBody.Contains((x,y)) || (snake.Head.Item1 == x && snake.Head.Item2 == y)){
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.Write("O");
                    text += "s";
                    continue;
                }
                else if(field.Fruit.Item1 == x && field.Fruit.Item2 == y){
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.Write("X");
                    text += "f";
                    continue;
                }
                //Console.Write(" ");
                text += " ";
            }
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("#");
            text += "#\n";
            return text;
        }
        static string EndRow(int width){
            string text = "";
            for(int i = 0; i<width; i++){
                text += "#"; //Console.Write("#");
            }
            text += "\n"; //Console.WriteLine();
            return text;
        }
    }
}