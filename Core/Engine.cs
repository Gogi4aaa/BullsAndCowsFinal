using BullsAndCowsFinal;
using BullsAndCowsFinal.Models;
public class Engine : IEngine
{
    public void Run()
    {
        Computer player1 = new Computer("PLAYER 1(COMP)");
        Computer player2 = new Computer("PLAYER 2(COMP)");
        Useful useful = new Useful();

        Player[] players = {player1, player2};

        int[] playersNumbered = {0, 1};
        string guess;
        int[] bullsAndCows;
        int i = 0;
        while (true)
        {
            Console.WriteLine("-------");

            Console.WriteLine($"{players[playersNumbered[0]].Name}, enter your guess!");
            guess = players[playersNumbered[0]].Say();
            Console.WriteLine($"{players[playersNumbered[0]].Name} says {guess}");
            bullsAndCows = useful.CheckNumbers(players[playersNumbered[1]].Signature, guess);
            Console.WriteLine($"{players[playersNumbered[1]].Name} says {bullsAndCows[0]} bulls and {bullsAndCows[1]} cows");

            players[playersNumbered[0]].History.Add(new KeyValuePair<string, int[]>(guess, bullsAndCows));

            if (bullsAndCows[0] == 4)
            {
                Console.WriteLine($"{players[playersNumbered[0]].Name} won the game!");
                Console.WriteLine($"{players[playersNumbered[0]].Name} won in {i / 2 + 1} turns");
                break;
            }

            Array.Reverse(playersNumbered);
            i++;
        }
    }
}