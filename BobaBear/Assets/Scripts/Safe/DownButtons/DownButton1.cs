using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton1 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num1 > 0)
        {
            GetComponentInParent<Safe>().num1--;
        }
        else
        {
            GetComponentInParent<Safe>().num1 = 9;
        }
        
    }
}
