using System;
using System.Collections.Generic;
namespace Snake
{
    class Snake
    { // tillämpa standardbiblioteket?
        (int, int) snakeHead;
        public List<(int, int)> snakeBody;
        int snakeBodyLength;
        int score;
        public int Score {get=>score;}
        public int Length
        {
            get => snakeBodyLength;
            set { snakeBodyLength = value; }
        }
        public (int, int) Head
        {
            get => snakeHead;
            set
            {
                snakeHead = value;
            }
        }
        public Snake(int x, int y, int length)
        {
            snakeHead = (x / 2, y / 2);
            snakeBody = new List<(int, int)>();
            snakeBodyLength = length;
            score = 5;
            for (int i = 0; i < snakeBodyLength; i++)
            {
                snakeBody.Add((snakeHead.Item1 - i - 1, snakeHead.Item2));
            }
        }
        public void Move()
        {
            for (int i = snakeBodyLength - 1; i > 0; --i)
            {
                snakeBody[i] = snakeBody[i-1];
            }
            snakeBody[0] = Head;
            MoveHead(UserInput.LastInput);
        }
        public void Eat()
        {
        snakeBody.Add(snakeBody[0]); 
        snakeBodyLength++;
        for (int i = snakeBodyLength - 1; i > 0; --i)
            {
                snakeBody[i] = snakeBody[i-1];
            }
        snakeBody[0] = Head;
        MoveHead(UserInput.LastInput);
        score += 5;
        }
        public void MoveHead(char input){
            switch (input)
            {
                case 'w':
                    Head = (Head.Item1, Head.Item2-1);
                    break;
                case 'a':
                    Head = (Head.Item1-1, Head.Item2);
                    break;
                case 's':
                   Head = (Head.Item1, Head.Item2+1);
                    break;
                case 'd':
                    Head = (Head.Item1+1, Head.Item2);
                    break;
            }
        }
    }
}