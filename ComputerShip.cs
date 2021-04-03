using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace battleship_console
{
    public class ComputerShip
    {
        public ArrayList locationCoords = new ArrayList();

        public int shotsRemaining = 2;

        public int numOfGuesses = 0;
        public void setLocationCoords(ArrayList loc)
        {
            locationCoords = loc;
        }
        public void checkUserGuess(string userInput)
        {
            int index = locationCoords.IndexOf(userInput.ToUpper());
            if (index >= 0)
            {
                locationCoords.Remove(userInput.ToUpper());
                if (locationCoords.Count <= 0)
                {
                    WriteLine("\nKill");
                    WriteLine("\nYou sunk my battleship!");
                    showShotsAndGuessesLeft();
                }
                else
                {
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine("\nHit");
                    ResetColor();
                    showShotsAndGuessesLeft();

                }
            }
            else
            {
                WriteLine("\nMiss");
                showShotsAndGuessesLeft();
            }
        }

        public void showShotsAndGuessesLeft()
        {
            shotsRemaining--;
            numOfGuesses++;
            WriteLine("You have " + shotsRemaining + " shots remaining and " + (8 - numOfGuesses) + " guesses left.");
        }
        public string getUserGuess()
        {
            bool parseSuccess = false;
            string userGuess;
            HashSet<char> valid = new HashSet<char>()
                   {'A','B','C','D','E','F','G','H','I','J'};
            do
            {
                WriteLine("\nEnter guess");
                userGuess = ReadLine();
                char coord = 'a';
                if (!string.IsNullOrEmpty(userGuess))
                {
                    var guessFirstChar = userGuess.Substring(0, 1);
                    var length = userGuess.Length;
                    if (char.TryParse(guessFirstChar, out coord) && length == 2)
                    {
                        if (valid.Contains(char.ToUpper(coord)))
                        {
                            parseSuccess = true;
                        }
                        else
                            WriteLine("\nNot a proper coordinate! Coordinate must be format A1, B2...");
                    }
                    else
                        WriteLine("\nNot a proper coordinate! Coordinate must be format A1, B2...");
                }
                else
                    WriteLine("\nGuess is empty! Please enter a coordinate such as A1, B2 ... ");
            }
            while (!parseSuccess);
            return userGuess;
        }

    }
}


