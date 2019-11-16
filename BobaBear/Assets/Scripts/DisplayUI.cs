using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour
{
    public string description; //object description (can change within the inspector)
    public Text text; //the text ui we are accessing
    public float fadeTime; //the time it takes for the text to fade in or out
    public bool isDisplayed; //whether or not the display text is being displayed

    // Start is called before the first frame update
    void Start()
    {
        text.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        FadeText(); 
    }


    private void OnMouseOver()
    {
        isDisplayed = true;
    }

    private void OnMouseExit()
    {
        isDisplayed = false;
    }
    
    void FadeText()
    {
        if (isDisplayed)
        {
            text.text = description;
            Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mp.z = -5;
            mp.x += .7f;
            mp.y -= .3f;
            text.transform.position = mp;
            text.color = Color.Lerp(text.color, Color.white, fadeTime * Time.deltaTime);
        }
        else
        {
        text.color = Color.Lerp(text.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }

}
