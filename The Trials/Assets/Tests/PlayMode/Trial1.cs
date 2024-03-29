using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Trial1
{
    [UnityTest]
    public IEnumerator Trial1WithEnumeratorPasses()
    {
        yield return null;
    }
}
