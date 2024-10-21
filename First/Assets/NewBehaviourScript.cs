using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int currentAge;
    void Start()
    {
        currentAge = 39;
        Debug.Log("Initial Age: " + currentAge);
        IncreaseAge(currentAge);

        IncreaseAge(currentAge, 10);
    }
    public void IncreaseAge(int currentAge)
    {
        currentAge += 1;
        Debug.Log("Age after 1 year: " + currentAge);
    }

    public void IncreaseAge(int currentAge, int yearsToAdd)
    {
        currentAge += yearsToAdd;
        Debug.Log("Age after " + yearsToAdd + " years: " + currentAge);
    }
}
