/*“Love”, “Fifteen”, “Thirty”, and “Forty”*/
using NUnit.Framework;
using System;

namespace GameTennis.Test
{
    public class TennisGameTest
    {
        public  TennisGame _partita;
        [SetUp]
        public void Setup()
    {
            _partita = new TennisGame();
    }
        [TestCase("Forty,Forty", "Deuce")]

        public void Score_Deuce(Tuple<string>input,string expected)
        {
           Assert.AreEqual(expected,_partita.Pareggio(input));
           
        }

        [TestCase("Forty,4","Advantage,2")]
        [TestCase("4,Forty", "Advantage,1")]
        public void Score_Vantaggio(Tuple<string>input,string expected)
        {
            Assert.AreEqual(expected, _partita.Vantaggio(input));
        }

        [TestCase("love,Fifteen", "love,Fifteen")]
        [TestCase("Fifteen,love", "Fifteen,love")]
        [TestCase("Thirty,love", "Thirty,love")]

        public void Score_Punteggio(Tuple<string>input, string expected)
        {
            Assert.AreEqual(expected, _partita.Punteggio(input));
        }
    }

   
}
