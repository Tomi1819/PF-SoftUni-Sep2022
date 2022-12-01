using System;
using System.Collections.Generic;

namespace _09._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            int numberOfPieces = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
                string piece = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];
                if (!pieces.ContainsKey(piece))
                {
                    pieces[piece] = new List<string>() { "",""};
                }
                pieces[piece][0] = composer;
                pieces[piece][1] = key;
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commArg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string commandName = commArg[0];

                if (commandName == "Add")
                {
                    string piece = commArg[1];
                    string composer = commArg[2];
                    string key = commArg[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces[piece] = new List<string>() { "",""};
                        pieces[piece][0] = composer;
                        pieces[piece][1] = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (commandName == "Remove")
                {
                    string piece = commArg[1];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (commandName == "ChangeKey")
                {
                    string piece = commArg[1];
                    string newKey = commArg[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
            }
            foreach (var kvp in pieces)
            {
                Console.WriteLine($"{kvp.Key} -> Composer: {kvp.Value[0]}, Key: {kvp.Value[1]}");
            }
        }
    }
}
