using System;


namespace Unit03
{
    //Handles input and output for the overall program.
    public class TerminalService
    {

        //Constructor.
        public TerminalService(){
        }

        //Reads the player's text based on a given prompt and returns it.
        public string ReadGuess(string prompt){
            string text = ReadText(prompt);
            return text;
        }

        //Displays a prompt and returns input from a user.
        public string ReadText(string prompt){
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}