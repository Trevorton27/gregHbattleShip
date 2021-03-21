using System;
using System.Collections;

namespace battleship_console
{
    class GameGrid
    {
        string [] alphabet = new [] {"A","B","C","D","E", "F", "G", "H", "I", "J"};
        private int gridLength = 10;
        private static int gridSize = 100;
        public ArrayList placeShip (int size) 
        {
            ArrayList randomCoords = new ArrayList(); 
                string temp = null;  
                int [] coords = new int[size];  
                bool success = false;      
                int location = 0; 

                while (!success)
                {
                Random randomGridCoords = new Random();
                location = (int) (randomGridCoords.Next(gridSize));
                    if ((location % gridLength) <= 5){
                    success = true;
                    }
                }

                int n = 0;
                while (n < size)
                {
                        coords[n++] = location;
                        location += 1;
                }
                
                int x = 0;
                int row = 0;
                int col = 0;
                while (x < size)
                {
                    row = (int) (coords[x] / gridLength);
                    col = coords[x] % gridLength;
                    temp = alphabet[col];
                    randomCoords.Add(string.Concat(temp,row.ToString()));
                    x++;
                    // System.Console.WriteLine(" coord "+x+" = " + randomCoords[x-1]);
                }
                return randomCoords; 
        }
         public void drawGrid ()
        {
                string gridUnits = " - - - - - - - - - -";
                System.Console.WriteLine("\n  1 2 3 4 5 6 7 8 9 10 ");
                for (int i = 0; i < gridLength; i++)
                {
                System.Console.WriteLine(alphabet[i] + gridUnits);
                }
        }
    }
}
