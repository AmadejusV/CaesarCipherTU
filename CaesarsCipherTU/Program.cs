using System;

namespace CaesarsCipherTU
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput = null;
            int encryptionKey = 0;
            string encryptedMsg = null;

            string choice = Cipher.GetUserInput("Choose an operation: enter - \n '1' to Encrypt message \n '2' to Decrypt message \n '3' to Cancel operation");

            switch (choice)
            {
                case "1":
                    userInput = Cipher.GetUserInput("Please enter a message you want to encrypt, preferably using english alphabet:");
                    encryptionKey = Cipher.GetEncryptionKey();
                    Cipher.EncryptInput(userInput, encryptionKey);
                    break;
                case "2":
                    encryptedMsg = Cipher.GetUserInput("Enter a message you want to decrypt:");
                    encryptionKey = Cipher.GetEncryptionKey();
                    Cipher.DecryptInput(encryptedMsg, encryptionKey);
                    break;
                case "3":
                    Console.WriteLine("Exiting operation");
                    break;
                default:
                    break;
            }
        }
    }
}
