using System;
using System.Collections.Generic;

namespace Unit03
{
    //Generates a random word for the player to guess for.
    class HiddenWord
    {
        private List<string> words = new List<string> {"Nephi", "Jacob", "Ammon", "Lehi", "Moroni", "Alma", "Teancum", "Helaman", "Pahoran",
        "Mormon", "Benjamin", "Laman", "Lemeul", "Sam", "Enos", "Mosiah", "Lamoni"};
        public string hiddenWord;
        public List<char> letters = new List<char>();
        public List<char> guess = new List<char>();



        //Constructor.
        public HiddenWord() {
        }

        //Picks a word from the array.
        public string pickWord(){
            Random rand = new Random();
            string chosen = words[rand.Next(0, words.Count)];
            return chosen;
        }

        //turns the chosen word into a list of character.
        public void getListFromWord(string split){
            letters.AddRange(split.ToLower());
        }

        //Generates the line of characters for the hint.
        public void getAnswer() {
            foreach (int i in letters){
                guess.Add('_');
            }
        }

        //Shows the hint line.
        public void printGuess(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));
        }

        //Checks if the characters guessed are within the chosen word, and adds to the attempts counter.
        public int compare(List<char> previous, int numGuesses){
            for (int i = 0; i < letters.Count; i++){
                if (previous.Contains(letters[i])){
                    guess[i] = letters[i];
                }
            }
            if (letters.Contains(previous[numGuesses - 1])){
                return 0;
            } else {
                return 1;
            }
        }

        //Prints the revealed word.
        public void printAnswer(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", letters)));
        }

    }
}