using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class Arrays : MonoBehaviour
{
    public class AddMultipleNumbers
    {
        [Test]
        public void AddMultipleNumbers_20()
        {
            int[] numbers = { 5, 10, 5 };
            Assert.AreEqual(20, Arrays_1.AddMultipleNumbers(numbers));
        }

        [Test]
        public void AddMultipleNumbers_0()
        {
            int[] numbers = {};
            Assert.AreEqual(0, Arrays_1.AddMultipleNumbers(numbers));
        }

        [Test]
        public void AddMultipleNumbers_80()
        {
            Arrays_1.ExampleForLoop();
            int[] numbers = { 20, -5, 45, 10, 10 };
            Assert.AreEqual(80, Arrays_1.AddMultipleNumbers(numbers));
        }
    }
}
