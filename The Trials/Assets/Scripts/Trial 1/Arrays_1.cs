using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Arrays_1 : MonoBehaviour
{
    private int[] testArray = {1, 4, 8, 12};

    // Arrays start at index 0
    // You can get the first element of a the testArray array like: testArray[0]

        // testArray[0] ==> 1
        // testArray[1] ==> 4
        // testArray[2] ==> 8
        // testArray[3] ==> 12

    

    // Example for loop
    // Not a test, just for reference

    public static void ExampleForLoop()
    {
        int[] testArray = {1, 4, 8, 12};

        for (int i = 0; i < testArray.Length; i++)
        {
            // i starts out as 0
            // then it continues looping and i will keep increasing until it's no longer less than testArray.Length

            // YOU CAN UNCOMMENT THE LINE BELOW TO SEE WHAT IT LOGS
            //Debug.Log(testArray[i]);
        }
    }



    // PARAMETERS: array of integers
    public static int AddMultipleNumbers(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            // numbers[i]
        }

        return sum;
    }
}
