using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class CounterTest : IDisposable
    {
        public void Dispose()
        {
            Counter.ClearAll();
        }

        [TestMethod]
        public void GetWriting_ReturnsCorrect_String()
        {
            //Arrange
            string userWriting = "I am a dog.";

            //Act
            Counter.SetWriting(userWriting);
            string result = Counter.GetWriting();

            //Assert
            Assert.AreEqual(userWriting, result);
        }

        [TestMethod]
        public void GetWord_ReturnsCorrect_String()
        {
            //Arrange
            string userWord = "dog";

            //Act
            Counter.SetWord(userWord);
            string result = Counter.GetWord();

            //Assert
            Assert.AreEqual(userWord, result);
        }

        [TestMethod]
        public void GetCounter_ReturnsNormalCountCorrect_String()
        {
            //Arrange
            string userWriting = "this is a dog i promise";
            string userWord = "dog";

            //Act
            Counter.SetWriting(userWriting);
            Counter.SetWord(userWord);
            int result = Counter.GetCount();

            //Assert
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void GetCounter_ReturnsCountCorrectWithAlphaNumericCharacters_String()
        {
            //Arrange
            string userWriting = "this is a dog! i belive this is also a dog? it is a dog.";
            string userWord = "dog";

            //Act
            Counter.SetWriting(userWriting);
            Counter.SetWord(userWord);
            int result = Counter.GetCount();

            //Assert
            Assert.AreEqual(3, result);

        }
    }
}