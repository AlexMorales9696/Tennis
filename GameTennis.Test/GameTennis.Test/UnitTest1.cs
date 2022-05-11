/*“Love”, “Fifteen”, “Thirty”, and “Forty”*/
using NUnit.Framework;
using System;

namespace GameTennis.Test
{
    public class UnitTest1
    {
        private TennisGame _partita;
        [SetUp]
        public void Setup()
    {
            _partita = new TennisGame();
    }
        [TestCase("Forty;Forty", "Deuce")]

        public void Score_Deuce(string input,string expected)
        {
           Assert.AreEqual(expected,_partita.Pareggio(input));
           
        }

        [TestCase("Forty-4","Advantage2")]
        [TestCase("4-Forty", "Advantage1")]
        public void Score_Vantaggio(string input ,string expected)
        {
            Assert.AreEqual(expected, _partita.Vantaggio(input));
        }

        [TestCase("love;Fifteen", "love;Fifteen")]
        [TestCase("Fifteen;love", "Fifteen;love")]
        [TestCase("Thirty;love", "Thirty;love")]

        public void Score_(string input, string expected)
        {
            Assert.AreEqual(expected, _partita.scor_(input));
        }
    }

    internal class TennisGame
    {
        internal object Pareggio(string input)
        {
            throw new NotImplementedException();
        }

        internal double scor_(string input)
        {
            throw new NotImplementedException();
        }

        internal double Vantaggio(string input)
        {
            throw new NotImplementedException();
        }
    }
}
