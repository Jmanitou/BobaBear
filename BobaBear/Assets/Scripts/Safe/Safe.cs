using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Safe : Object
{
    public GameObject text;
    public GameObject upButton;
    public GameObject downButton;
    public GameObject openSafe;

    public int num1;
    public int num2;
    public int num3;
    public int num4;
    public int num5;
    public int num6;

    Vector3 originalSize;
    Vector3 originalPosition;

    TextMeshPro text1;
    TextMeshPro text2;
    TextMeshPro text3;
    TextMeshPro text4;
    TextMeshPro text5;
    TextMeshPro text6;

    string correct1;
    string correct2;
    string correct3;

    bool open;

    // Start is called before the first frame update
    void Start()
    {
        open = false;
        zoomedIn = false;

        originalSize = transform.localScale;
        originalPosition = transform.position;

        num1 = 1;
        num2 = 2;
        num3 = 3;
        num4 = 4;
        num5 = 5;
        num6 = 6;

        correct1 = "83";
        correct2 = "40";
        correct3 = "67";

        //reference all numberTexts
        text1 = GameObject.Find("num1Text").GetComponent<TextMeshPro>();
        text2 = GameObject.Find("num2Text").GetComponent<TextMeshPro>();
        text3 = GameObject.Find("num3Text").GetComponent<TextMeshPro>();
        text4 = GameObject.Find("num4Text").GetComponent<TextMeshPro>();
        text5 = GameObject.Find("num5Text").GetComponent<TextMeshPro>();
        text6 = GameObject.Find("num6Text").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (zoomedIn)
        {
            ZoomOut();
            CheckForCorrect();
            UpdateText();
        }
        if (open == true)
        {

        }
    }

    void CheckForCorrect()
    {
        string numString1 = num1 + "" + num2;
        string numString2 = num3 + "" + num4;
        string numString3 = num5 + "" + num6;

        if (correct1 == numString1 && correct2 == numString2 && correct3 == numString3)
        {
            //Password is correct
            open = true;
            Debug.Log("Correct");
        }
    }

    void UpdateText()
    {
        text1.SetText(num1.ToString());
        text2.SetText(num2.ToString());
        text3.SetText(num3.ToString());
        text4.SetText(num4.ToString());
        text5.SetText(num5.ToString());
        text6.SetText(num6.ToString());
    }

    void OnMouseDown()
    {
        if (zoomedIn == false)
        {
            zoomedIn = true;
            transform.position = Camera.main.transform.position;
            Vector3 pos = transform.position;
            pos.z = -2;
            pos.y += 1;
            transform.position = pos;
            transform.localScale *= 6;
        }
    }

    void ZoomOut()
    {
        if (zoomedIn)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                transform.localScale = originalSize;
                transform.position = originalPosition;
                zoomedIn = false;
            }
        }
    }

    void OpenSafe()
    {
        
    }
}
