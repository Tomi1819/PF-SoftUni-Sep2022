using System;
using System.Text;

namespace _07._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string encryptedMessage = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] info = command.Split("|");
                string comName = info[0];

                if (comName == "Move")
                {
                    int numberOfLetters = int.Parse(info[1]);

                    string firstPart = encryptedMessage.Substring(0, numberOfLetters);
                    string secondPart = encryptedMessage.Substring(numberOfLetters);

                    sb.Append(firstPart);
                    encryptedMessage = secondPart + sb;
                }
                else if (comName == "Insert")
                {
                    int index = int.Parse(info[1]);
                    string value = info[2];

                    encryptedMessage = encryptedMessage.Insert(index, value);
                }
                else if (comName == "ChangeAll")
                {
                    string substring = info[1];
                    string replacement = info[2];
                    encryptedMessage = encryptedMessage.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
