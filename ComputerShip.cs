using System;
using System.Collections;

namespace battleship_console
{
    public class ComputerShip
    {
           public static ArrayList locationCells = new ArrayList();
           string result;

           public static int size;

             public void setLocationCells( ArrayList loc) {
               locationCells = loc;
              
           }

             public string checkUserGuess(string userInput)
           {
               System.Console.WriteLine(userInput);
               int index = locationCells.IndexOf(userInput);
               System.Console.WriteLine(index);
               if (index >= 0) 
               {
                   locationCells.Remove(index);
                   if (locationCells == null) 
                   {
                       result.Replace("miss", "kill");
                       System.Console.WriteLine("You sunk my battleship!");
                   }
               } else 
               {
                   result.Replace("miss","hit");
               }
               return result;
           }
           
    }               
}

