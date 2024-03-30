using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class _Functions
{
    public class AddNumbers
    {
        [Test]
        public void AddNumbers_Equals_15()
        {
            Assert.AreEqual(15, Functions_0.AddNumbers(10, 5));
        }

        [Test]
        public void AddNumbers_Equals_100()
        {
            Assert.AreEqual(100, Functions_0.AddNumbers(50, 50));
        }

        [Test]
        public void AddNumbers_Equals_8()
        {
            Assert.AreEqual(8, Functions_0.AddNumbers(0, 8));
        }
    }

    public class IsPlayerDead
    {
        [Test]
        public void IsPlayerDead_Equals_True()
        {
            Assert.IsTrue(Functions_0.IsPlayerDead(20));
        }

        [Test]
        public void IsPlayerDead_Equals_False()
        {
            Assert.IsFalse(Functions_0.IsPlayerDead(1));
        }
    }
}
