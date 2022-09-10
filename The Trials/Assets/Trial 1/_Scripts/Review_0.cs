using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BEAN
{
    public class Review_0 : MonoBehaviour
    {
        /* Basic varriable types
            - string ==> "some text"
            - int    ==> 10
            - float  ==> 15.50
            - bool   ==> false
        */

        // Example varriable
        private string yourName = "Efie"; 

        // Example if statement
        /*
            if (yourName == "Efie")
            {
                Debug.Log("Your name is Efie");
            }
        */

        // Example if else statement
        /*
            if (yourName == "Efie")
            {
                Debug.Log("Your name is Efie");
            } else 
            {
                Debug.Log("Your name is NOT Efie");
            }
        */


        // GOAL: create a varriable of type int, and name it health. Then give it an intial value of 10.
        // Inside the start function, create an if statement.
        // It should Debug.Log("Dead"); if the player's health is less than or equal to 0.
        // Otherwise should Debug.Log("Alive");

        void Start()
        {
            
        }
    }
}
