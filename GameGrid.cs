using System;
using System.Collections;

namespace battleship_console
{
    class GameGrid
    {
        private int gridLength = 10;
        private static int gridSize = 100;
        private int [] grid = new int[gridSize];

        public ArrayList placeShip () {
            ArrayList findCells = new ArrayList();

                Boolean success = false;
               int location = 0; 
            while (!success) {
                Random randomGridCoords = new Random();
                location = (int) (randomGridCoords.Next(gridLength, gridSize);
            }
        }
    }
}