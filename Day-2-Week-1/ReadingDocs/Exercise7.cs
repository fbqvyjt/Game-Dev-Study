using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int ogFahTemp;
        int celTemp;
        int fahCelTemp;

        // calculate and display for 0 degrees
        ogFahTemp = 0;
        print("Original Fahrenheit: " + ogFahTemp);
        celTemp = (ogFahTemp - 32) / 9 * 5;
        print("Calculated Celsius: " + celTemp);
        fahCelTemp = (celTemp * 9) / 5 + 32;
        print("Calculated Fahrenheit: " + fahCelTemp);

        // calculate and display for 32 degrees
        ogFahTemp = 32;
        print("Original Fahrenheit: " + ogFahTemp);
        celTemp = (ogFahTemp - 32) / 9 * 5;
        print("Calculated Celsius: " + celTemp);
        fahCelTemp = (celTemp * 9) / 5 + 32;
        print("Calculated Fahrenheit: " + fahCelTemp);

        // calculate and display for 212 degrees
        ogFahTemp = 212;
        print("Original Fahrenheit: " + ogFahTemp);
        celTemp = (ogFahTemp - 32) / 9 * 5;
        print("Calculated Celsius: " + celTemp);
        fahCelTemp = (celTemp * 9) / 5 + 32;
        print("Calculated Fahrenheit: " + fahCelTemp);

        // declare float variables
        double floatOgFah;
        double floatCel;
        double floatFahCel;

        // calculate and display for 0 degrees using float
        floatOgFah = 0;
        print("Float Original Fahrenheit: " + floatOgFah);
        floatCel = (floatOgFah - 32) / 9 * 5;
        print("Float Calculated Celsius: " + floatCel);
        floatFahCel = (floatCel * 9) / 5 + 32;
        print("Float Calculated Fahrenheit: " + floatFahCel);

    }
}
