using System;
using System.Collections;

namespace battleship_console
{
    public class ComputerShip
    {
           public  ArrayList locationCoords = new ArrayList();       
           public static int size;
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
                System.Console.WriteLine("\nEnter guess");                
                var userGuess = System.Console.ReadLine();
                if(string.IsNullOrEmpty(userGuess))
                {
                    System.Console.WriteLine("\nGuess is empty! Please enter a coordinate such as A1, B2 ... ");
                    userGuess = System.Console.ReadLine();
                } else if ()
                return userGuess;
            }
    }               
}

