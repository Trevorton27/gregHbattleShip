using System;
using System.Collections;

namespace battleship_console
{
    public class ComputerShip
    {
           public static ArrayList locationCoords = new ArrayList();
           string result = "miss";         
           public static int size;
             public void setLocationCoords( ArrayList loc) {
               locationCoords = loc;
           }
             public void checkUserGuess(string userInput)
           {
               int index = locationCoords.IndexOf(userInput);
               System.Console.WriteLine(locationCoords[0]);
               if (index >= 0) 
               {
                   locationCoords.Remove(userInput);
                   if (locationCoords.Count <= 0) 
                   {
                       string indexKill = result.Replace("miss", "kill");
                       System.Console.WriteLine(indexKill);
                       System.Console.WriteLine("You sunk my battleship!");
                    } else 
                        {
                            string indexHit = result.Replace("miss","hit");
                             System.Console.WriteLine(indexHit);
                         }  
                } else 
                    {
                        System.Console.WriteLine(result);
                    }
           
        }  
    }               
}

