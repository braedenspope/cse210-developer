using System;

namespace Unit02
{
    class Program
    {
        //Initalizes the Director and starts the game
        static void Main(string[] args)
        {
            Director director = new Director();
            director.Start();
        }
    }
}