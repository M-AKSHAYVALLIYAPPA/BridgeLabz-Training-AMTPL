using System;

public class Program
{
    public static void Main(string[] args)
    {

        Random random = new Random();

        const int WINNING_POSITION = 100;
        const int START_POSITION = 0;

        int player1_position = START_POSITION;
        int player2_position = START_POSITION;

        int currentPlayer = 1; // 1 for Player 1, 2 for Player 2
        int totalDiceRolls = 0;


        int numberOfPlayers = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Snake and Ladder!");
            Console.Write("How many players? (1 or 2): ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                numberOfPlayers = 1;
                break; // Exit the loop
            }

            if (input == "2")
            {
                numberOfPlayers = 2;
                break; // Exit the loop
            }

            Console.WriteLine("Invalid input. Please press Enter and try again.");
            Console.ReadLine();
        }

        Console.WriteLine("--- Snake and Ladder Game Started ---");
        Console.WriteLine($"Player 1 at {START_POSITION}");
        if (numberOfPlayers == 2)
        {
            Console.WriteLine($"Player 2 at {START_POSITION}");
        }


        while (player1_position != WINNING_POSITION && player2_position != WINNING_POSITION)
        {

            string currentPlayerName;
            int currentPosition;

            if (currentPlayer == 1)
            {
                currentPlayerName = "Player 1";
                currentPosition = player1_position;
            }
            else
            {
                currentPlayerName = "Player 2";
                currentPosition = player2_position;
            }


            Console.WriteLine($"\n[{currentPlayerName}] It's your turn (at position {currentPosition}).");
            Console.Write("Press Enter to roll the die...");
            Console.ReadLine(); // Wait for user input


            int dieRoll = random.Next(1, 7); // UC 2: Roll 1-6
            totalDiceRolls++; // UC 6
            int option = random.Next(0, 3); // UC 3: 0=NoPlay, 1=Ladder, 2=Snake

            int previousPosition = currentPosition;
            bool getsAnotherTurn = false;
            string optionName = "";


            if (option == 0) // 0 is NoPlay
            {
                optionName = "No Play";
                // UC 3: Position stays the same
            }
            else if (option == 1) // 1 is Ladder
            {
                optionName = "Ladder";
                int newPosition = currentPosition + dieRoll; // UC 3: Move ahead

                if (newPosition > WINNING_POSITION) // UC 5: Overshoot
                {
                    currentPosition = previousPosition; // Stay put
                    getsAnotherTurn = false; // Our clarified rule
                }
                else
                {
                    currentPosition = newPosition; // Valid move
                    getsAnotherTurn = true; // UC 7: Play again
                }
            }
            else // 2 is Snake
            {
                optionName = "Snake";
                currentPosition -= dieRoll; // UC 3: Move back

                if (currentPosition < START_POSITION) // UC 4: Undershoot
                {
                    currentPosition = START_POSITION; // Restart at 0
                }
            }


            if (currentPlayer == 1)
            {
                player1_position = currentPosition;
            }
            else
            {
                player2_position = currentPosition;
            }


            Console.WriteLine($"[{currentPlayerName}] Roll: {dieRoll}, Option: {optionName}, " +
                              $"Position: {previousPosition} -> {currentPosition}");


            if (currentPosition == WINNING_POSITION)
            {
                Console.WriteLine($"\n--- GAME OVER ---");
                Console.WriteLine($"{currentPlayerName} won the game!"); // UC 7
                break; // Exit the main 'while' loop
            }


            if (getsAnotherTurn == true)
            {
                Console.WriteLine($"[{currentPlayerName}] got a Ladder! Playing again.");
                // Do not switch players
            }
            else
            {
                // Only switch if it's a 2 player game
                if (numberOfPlayers == 2)
                {
                    if (currentPlayer == 1)
                    {
                        currentPlayer = 2;
                    }
                    else
                    {
                        currentPlayer = 1;
                    }
                }
            }
        } // --- End of Main Game Loop ---


        Console.WriteLine($"Total dice rolls to win: {totalDiceRolls}");
    }
}

