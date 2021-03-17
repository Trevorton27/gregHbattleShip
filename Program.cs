using System;

namespace battleship_console
{
         
    class Battleship
    {
        private GameGrid gameGrid = new GameGrid();
        private int numOfGuesses = 0;
        private void setUpGame () {
            ship = new Ship(5);

            System.Console.WriteLine("Welcome! Your goal is to sink the battleship");
            System.Console.WriteLine("Try to sink the ship within 8 guesses");

            ArrayList<String> newLocation = gameGrid.placeShip();
        }

        private void startGame () {
            while(!ship.isEmpty()) {
                System.Console.WriteLine("Enter guess");
                var userGuess = System.Console.ReadLine();
                checkUserGuess(userGuess);
            }
            finishGame();
        }

        private void checkUserGuess(String userGuess) {
            numOfGuesses++;

            var result = "miss";
            for(int i = 0; i < ship.size(); i++ ) {

            if (result.Equals("hit")) {
                break;
            }
            if (result.Equals("kill")) {
                ship.remove(x);
                break;
            }
        }
        System.Console.WriteLine(result);

        }

        private void finishGame () {
            System.Console.WriteLine("You sunk my battleship!");
            if (numOfGuesses <= 7) {
                System.Console.WriteLine("It only took you" + numOfGuesses + " guesses");
            } else {
                System.Console.WriteLine("Took you long enough");
            }

        }

        static void Main(string[] args)
        {
            Battleship game = new Battleship();
            game.setUpGame();
            game.startGame();
        }
    }
}
