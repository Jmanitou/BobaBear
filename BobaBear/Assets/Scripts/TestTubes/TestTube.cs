using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTube : Object
{
    string chemical;
    string color;
    // Start is called before the first frame update
    void Start()
    {
        chemical = gameObject.name;
        switch (chemical)
        {
            case "Nitrogen Dioxide":
                color = "cyan";
                break;
            case "Sulfuric Acid":
                color = "purple";
                break;
            case "Glycerol":
                color = "green";
                break;
            case "Chlorine":
                color = "red";
                break;
            case "Methane":
                color = "yellow";
                break;
            case "Sodium Hydroxide":
                color = "black";
                break;
            case "Barium Chlorate":
                color = "orange";
                break;
            case "Fluorine":
                color = "magenta";
                break;
            case "Ammonia":
                color = "blue";
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
