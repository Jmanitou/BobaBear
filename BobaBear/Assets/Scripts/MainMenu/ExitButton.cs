using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<MenuMain>().instructionsOpen == false)
        {
            Application.Quit();
        }
    }
}
