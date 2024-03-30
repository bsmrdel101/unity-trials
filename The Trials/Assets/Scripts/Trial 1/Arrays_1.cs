using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Arrays_2 : MonoBehaviour
{
    private int[] numbers = {1, 2, 3, 4};

    // numbers[0] ==> 1
    // numbers[1] ==> 2
    // numbers[2] ==> 3
    // numbers[3] ==> 4

    

    // Example for loop
    private void ExampleForLoop()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }



    // GOAL: Create a function that will use a for loop, to loop through all the names.
    // If it detects the name Joe then it will return true.
    // If the return value is true, then Debug.Log("Joe has been located");

    private string[] names = {"Steve", "Bob", "Joe", "Jane"};

    void Start()
    {

    }
}
