using System;
using System.Threading;
namespace Snake
{
    class UserInput
    {
        static char lastInput = 'd';
        static public bool Read()
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
                    switch(input, lastInput){
                        case ('a', 'd'): continue;
                        case ('d', 'a'): continue;
                        case ('w', 's'): continue;
                        case ('s', 'w'): continue;
                    }
                if(!(input == 'a' || input == 'w' || input == 's' || input == 'd')){
                    return false;
                }    
                    lastInput = input;
                }
            }
            return true;
        }
        static public char LastInput
        {
            get {return lastInput;}
            set{lastInput = value;}
        }
    }
}