using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12Aug2106
{
   public class EncryptDecryptMsg
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Message:");
            var message = Console.ReadLine();

            Console.WriteLine("Original Message:\n{0}", message);
            var encryptDecyptMsg = new EncryptDecryptMsg();

            var decryptedMessage = encryptDecyptMsg.EncryptMessage(message);
            Console.WriteLine();
            Console.WriteLine("Encrypted Message:\n{0}", decryptedMessage);
            var encryptedMessage = encryptDecyptMsg.DecryptMessage(decryptedMessage);

            Console.WriteLine();
            Console.WriteLine("Decrypted Message:\n{0}", encryptedMessage);
        }
        public string EncryptMessage(string inputString)
        {
            var message = string.Empty;
            var indexes = new List<int>();
            var index = 1;
            var sb = new StringBuilder();
            try
            {
                foreach (char character in inputString)
                {
                    if (character == ' ')
                    {
                        indexes.Add(index);
                    }
                    else
                    {
                        index++;
                        message = message + character;
                    }
                }

                var columns = (int) Math.Ceiling(Math.Sqrt(message.Length));
                var messageInRows = SplittingMessageIntoRows(message, columns).ToList();

                for (var i = 0; i < columns; i++)
                {
                    foreach (var rowMsg in messageInRows)
                    {
                        if (rowMsg.Length > i)
                        {
                            sb.Append(rowMsg.Substring(i, 1));
                        }
                    }
                    sb.Append(" ");
                }

                sb.Append("numsp ");
                sb.Append(string.Join(" ", indexes));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:{0}", ex.Message);
            }
            return sb.ToString();
        }

        private IEnumerable<String> SplittingMessageIntoRows(string s, int partLength)
        {
            for (var i = 0; i < s.Length; i += partLength)
            {
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
            }
        }

        public string DecryptMessage(string decryptedMessage)
        {
            var encryptedMessage = string.Empty;
            try
            {
                var numspIndex = decryptedMessage.LastIndexOf("numsp");
                var message = decryptedMessage.Substring(0, numspIndex).Trim();
                var messageIntoRows = message.Split(' ').ToList();
                var rows = (int) Math.Floor(Math.Sqrt(message.Length));

                var sb = new StringBuilder();
                for (var i = 0; i < rows; i++)
                {
                    foreach (var rowMsg in messageIntoRows)
                    {
                        if (rowMsg.Length > i)
                        {
                            sb.Append(rowMsg.Substring(i, 1));
                        }
                    }
                }
                encryptedMessage = sb.ToString();
                var arrIndex = decryptedMessage.Substring(numspIndex + 6);// Getting only indexes
                if (arrIndex.Length > 0) //should have index numbers for given string
                {
                    var arrIndexes = Array.ConvertAll(arrIndex.Trim().Split(' '), int.Parse);
                    for (var i = 0; i < arrIndexes.Length; i++)
                    {
                        encryptedMessage = encryptedMessage.Insert(arrIndexes[i] - 1 + i, " ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:{0}", ex.Message);
            }
            return encryptedMessage;
        }
    }
}
