using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Think of a number...");
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("The highest number you can pick is: " + max);

        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
