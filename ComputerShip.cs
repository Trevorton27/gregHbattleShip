using System;
using System.Collections;
using System.Collections.Generic;

namespace battleship_console
{
    public class ComputerShip
    {
           public  ArrayList locationCoords = new ArrayList();       
             public void setLocationCoords( ArrayList loc) {
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
                       System.Console.WriteLine("\nKill");
                       System.Console.WriteLine("\nYou sunk my battleship!");
                    } else 
                        {
                            System.Console.BackgroundColor = ConsoleColor.Red;
                             System.Console.WriteLine("\nHit");
                             System.Console.ResetColor();
                         }  
                } else 
                    {
                        System.Console.WriteLine("\nMiss");
                    }
            }
               public string getUserGuess()
               {
                   bool parseSuccess = false;
                   string userGuess;
                   HashSet<char> valid = new HashSet<char>() 
                   {'A','B','C','D','E','F','G','H','I','J'};
                   do
                   {
                       System.Console.WriteLine("\nEnter guess");
                       userGuess = System.Console.ReadLine();
                       char coord = 'a';
                       if(!string.IsNullOrEmpty(userGuess))
                       {
                            var guessFirstChar = userGuess.Substring(0,1);
                            var length = userGuess.Length;
                            if(char.TryParse(guessFirstChar, out coord) && length ==2)
                            {
                                if (valid.Contains(char.ToUpper(coord)))
                                {
                                    parseSuccess = true;
                                }
                                else
                                    System.Console.WriteLine("\nNot a proper coordinate! Coordinate must be format A1, B2...");
                            } 
                            else
                                System.Console.WriteLine("\nNot a proper coordinate! Coordinate must be format A1, B2...");
                        }       
                        else
                            System.Console.WriteLine("\nGuess is empty! Please enter a coordinate such as A1, B2 ... "); 
                    }  
                    while(!parseSuccess);
                    return userGuess;
                }
     
            }
    }               


