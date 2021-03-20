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
               System.Console.WriteLine(userInput);
               System.Console.WriteLine(locationCoords[0]);
               if (index >= 0) 
               {
                   locationCoords.Remove(userInput.ToUpper());
                   if (locationCoords.Count <= 0) 
                   {
                       System.Console.WriteLine("Kill");
                       System.Console.WriteLine("You sunk my battleship!");
                    } else 
                        {
                             System.Console.WriteLine("Hit");
                         }  
                } else 
                    {
                        System.Console.WriteLine("Miss");
                    }
           
        }  
    }               
}

