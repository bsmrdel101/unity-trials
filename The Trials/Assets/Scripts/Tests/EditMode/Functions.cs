using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Functions
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
