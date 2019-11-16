using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : Object
{
    public GameObject text;
    public GameObject upButton;
    public GameObject downButton;

    List<GameObject> upButtons;
    List<GameObject> downButtons;
    List<GameObject> numbers;

    int num1;
    int num2;
    int num3;
    int num4;
    int num5;
    int num6;


    string correct1;
    string correct2;
    string correct3;

    // Start is called before the first frame update
    void Start()
    {
        num1 = 0;
        num2 = 0;
        num3 = 0;
        num4 = 0;
        num5 = 0;
        num6 = 0;

        correct1 = "83";
        correct2 = "40";
        correct3 = "67";
    }

    // Update is called once per frame
    void Update()
    {
        CheckForCorrect();
    }

    void CheckForCorrect()
    {
        string numString1 = num1 + "" + num2;
        string numString2 = num3 + "" + num4;
        string numString3 = num5 + "" + num6;

        if (correct1 == numString1 && correct2 == numString2 && correct3 == numString3)
        {
            //Password is correct
            Debug.Log("Correct");
        }
    }
}
