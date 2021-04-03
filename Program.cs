using System;
using System.Text;
using static System.Console;

namespace battleship_console
{

    class Battleship
    {
        private GameGrid gameGrid = new GameGrid();
        private ComputerShip ship = new ComputerShip();
        private int shipSize;


        private void setUpGame()
        {
            shipSize = 5;

            WriteLine("\n\nWelcome! Your goal is to sink the battleship...");
            WriteLine("\nTry to sink the ship within 8 guesses");
            WriteLine("\nEnter a letter from the left side of the grid and a number from the top.");
            WriteLine("\nThat will equal the coordinates for your fire.");

            gameGrid.drawGrid();

            var newLocation = gameGrid.placeShip(shipSize);
            ship.setLocationCoords(newLocation);
        }

        private void startGame()
        {

            while (ship.locationCoords.Count > 0 && ship.numOfGuesses <= 8 && ship.shotsRemaining != 0)
            {
                Clear();
                var userGuess = ship.getUserGuess();
                ship.checkUserGuess(userGuess);

                gameGrid.drawGrid();
            }
            finishGame();
        }
        private void finishGame()
        {
            WriteLine("\nGame Over!");
            if (ship.numOfGuesses <= 8)
            {
                WriteLine("\nIt only took you " + ship.numOfGuesses + " guesses\n");
            }
            else
            {
                WriteLine("\nSorry! You're out of guesses\n");
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Battleship game = new Battleship();
                game.setUpGame();
                game.startGame();
                Console.WriteLine("Play Again? [Y | N]");
            }
            while (Console.ReadLine().ToUpper() != "N");
        }
    }

}



