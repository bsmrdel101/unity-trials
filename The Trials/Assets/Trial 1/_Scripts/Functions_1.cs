using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BEAN 
{
    public class Functions_1 : MonoBehaviour
    {
        // Example function
        /*
            void Start()
            {
                SayHi();  <==== This line will call the SayHi() function.
            }

            private void SayHi()
            {
                Debug.Log("Hi");
            }
        */

        // Example function with parameters
        /*
            void Start()
            {
                SaySomething("Hello");  <==== Parameters values go inside of these parrenthesis.
            }

            private void SayHi(string word)  <==== Parameters are like a temporary varriable.
            {
                Debug.Log(word); <==== In this example the console should log "Hello".
            }
        */



        // GOAL 1: Create a function that adds to numbers together, and logs the result to the console.

        // Do goal 2 after completing the first one.
        // GOAL 2: Modify your code to return the answer, and set the varraible answer equal to the returned value. Then Debug.Log(answer);. See more details below.

        private int answer;

        void Start()
        {
            
        }

        // Your function should go here
    }





    // Example function with a return value
    /*
        private string wordToSay;

        void Start()
        {
            wordToSay = SayHi("Hello");
            Debug.Log(wordToSay);
        }

        private string SayHi(string word)
        {
            return word;
        }
    */
}
