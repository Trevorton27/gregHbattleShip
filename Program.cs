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
        private void setUpGame () 
        {
            shipSize = 5;

            System.Console.WriteLine("Welcome! Your goal is to sink the battleship");
            System.Console.WriteLine("Try to sink the ship within 8 guesses");

           var newLocation = gameGrid.placeShip(shipSize);
           ship.setLocationCoords(newLocation);           
        }

        private void startGame () {
                
                bool success = true;

                while (success) {
                System.Console.WriteLine("Enter guess");
                var userGuess = System.Console.ReadLine();
                ship.checkUserGuess(userGuess);
                }
            }
            // finishGame();

        // private void checkUserGuess(String userGuess) {
        //     numOfGuesses++;

        //     var result = "miss";
        //     for(int i = 0; i < ship.size(); i++ ) {

        //     if (result.Equals("hit")) {
        //         break;
        //     }
        //     if (result.Equals("kill")) {
        //         ship.remove(x);
        //         break;
        //     }
        // }
        // System.Console.WriteLine(result);

        
        // private void finishGame () {
        //     System.Console.WriteLine("You sunk my battleship!");
        //     if (numOfGuesses <= 7) {
        //         System.Console.WriteLine("It only took you" + numOfGuesses + " guesses");
        //     } else {
        //         System.Console.WriteLine("Took you long enough");
// 
// 
// 

        static void Main(string[] args)
        {
            Battleship game = new Battleship();
            game.setUpGame();
            game.startGame();
        }   
    }

}   
   
  

