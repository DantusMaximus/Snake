using System;
namespace Snake{
    class Field{
        (int, int) fruit;
        int width;
        int height;
        Random random;
        public (int, int) Fruit{
            get=>fruit;
            set{fruit = value;}
        }
        public int Width { get=> width;}
        public int Heigth { get=> height;}
        public Field(int x, int y){
            width = x;
            height = y;
            random = new System.Random();
            fruit = (random.Next(0, width),random.Next(0, height));
        }
        public void GenerateFruit(){
            fruit.Item1 = random.Next(0, width-1);
            fruit.Item2 = random.Next(0, height-1);
        }
        
    }
}