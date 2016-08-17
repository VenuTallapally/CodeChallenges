using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _12Aug2106;

namespace _12Aug2016Tests
{
    [TestClass]
    public class EncryptDecryptMsgTests
    {
        [TestMethod]
        public void MustEncryptDecryptMessage()
        {
            var codeChallenge = new EncryptDecryptMsg();
            var message = "if man was meant to stay on the ground god would have given us roots";
            //var message = "have a nice day";
            Console.WriteLine("Original Message:\n{0}", message);
            var decryptedMessage = codeChallenge.EncryptMessage(message);
            Console.WriteLine("");
            Console.WriteLine("Encrypted Message:\n{0}", decryptedMessage);
            var encryptedMessage = codeChallenge.DecryptMessage(decryptedMessage);
            Console.WriteLine();
            Console.WriteLine("Decrypted Message:\n{0}", encryptedMessage);
        }
    }
}
