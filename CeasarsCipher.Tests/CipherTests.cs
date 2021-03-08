using CaesarsCipherTU;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CeasarsCipher.Tests
{
    public class CipherTests
    {

        //arrange
        string input = "SuPer Duper long meSSage 19514bam";
        int encryptionKey = 59311%26;
        string encryptedInput = "XzUjw%Izujw%qtsl%rjXXflj%6>:69gfr";

        [Fact]
        public void Encryption()
        {
            var expected = encryptedInput;

            //act
            var actual = Cipher.EncryptInput(input, encryptionKey);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Decryption()
        {
            var expected = input;

            //act
            var actual = Cipher.DecryptInput(encryptedInput, encryptionKey);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
