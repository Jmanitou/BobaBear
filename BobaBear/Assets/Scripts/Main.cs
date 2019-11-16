using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    string state;
    string room;
    string zoomed;
    string win;
    string lose;

    // Start is called before the first frame update
    void Start()
    {
        //Create string for each state
        room = "room";
        zoomed = "zoomed";
        win = "win";
        lose = "lose";

        //Starting state is menu
        state = room;
    }

    // Update is called once per frame
    void Update()
    {
        //Change based on state
        switch (state)
        {
            case "room":
                break;

            case "zoomed":
                break;

            case "win":
                break;

            case "lose":
                break;

            default:
                break;
        }
    }
}
