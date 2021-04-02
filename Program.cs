using System;
using System.Text;

namespace battleship_console
{

    class Battleship
    {
        private GameGrid gameGrid = new GameGrid();
        private ComputerShip ship = new ComputerShip();
        private int shipSize;
        private int numOfGuesses = 0;
        private void setUpGame()
        {
            shipSize = 5;

            System.Console.WriteLine("\n\nWelcome! Your goal is to sink the battleship...");
            System.Console.WriteLine("\nTry to sink the ship within 8 guesses");

            gameGrid.drawGrid();

            var newLocation = gameGrid.placeShip(shipSize);
            ship.setLocationCoords(newLocation);
        }

        private void startGame()
        {

            while (ship.locationCoords.Count > 0 && numOfGuesses <= 8)
            {
                var userGuess = ship.getUserGuess();
                ship.checkUserGuess(userGuess);
                numOfGuesses++;
                gameGrid.drawGrid();
            }
            finishGame();
        }
        private void finishGame()
        {
            System.Console.WriteLine("\nGame Over!");
            if (numOfGuesses <= 7)
            {
                System.Console.WriteLine("\nIt only took you " + numOfGuesses + " guesses\n");
            }
            else
            {
                System.Console.WriteLine("\nSorry! out of guesses\n");
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



