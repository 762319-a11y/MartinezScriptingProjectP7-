using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifstames : MonoBehaviour
{

    //Creating my 3 variable
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //this if statement will call the temperature test fuction and check if the coffee is too hot or cold
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }
        //decrease the teaperture of the coffee over time
        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");

    }
        }
}