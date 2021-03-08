using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarsCipherTU
{
    public class Cipher
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            while (input.Length<1)
            {
                Console.WriteLine("Message cannot be empty, enter your a message to decrypt.");
                input = Console.ReadLine();
            }

            return input;
        }

        public static int GetEncryptionKey()
        {
            Console.WriteLine("Enter an encription key in numeric value:");
            string encryptionKey;

            bool isNumValid = false;
            int key = 0;

            while (!isNumValid)
            {
                encryptionKey = Console.ReadLine();
                isNumValid = int.TryParse(encryptionKey, out key);

                if (!isNumValid)
                {
                    Console.WriteLine($"{encryptionKey} is not a valid input, please enter a numeric value.");
                }
            }

            Console.WriteLine(key % 26);
            return key % 26;
        }


        public static string EncryptInput(string userInput, int encryptionKey)
        {
            string encryptedMessage = null;
            char[] letterArray = null;
            int temp = 0;

            letterArray = userInput.ToCharArray();

            for (int i = 0; i < userInput.Length; i++)
            {
                temp = (int)letterArray[i] + encryptionKey;
                encryptedMessage += (char)temp;
            }
            Console.WriteLine($"This is your encrypted message: \n{encryptedMessage}");
            return encryptedMessage;
        }


        public static string DecryptInput(string encryptedInput, int encryptionKey)
        {
            string decryptedMessage = null;
            char[] letterArray = null;
            int temp = 0;

            letterArray = encryptedInput.ToCharArray();

            for (int i = 0; i < encryptedInput.Length; i++)
            {
                temp = (int)letterArray[i] - encryptionKey;
                decryptedMessage += (char)temp;
            }
            Console.WriteLine($"This is your decrypted message: \n{decryptedMessage}");
            return decryptedMessage;
        }
    }
}
