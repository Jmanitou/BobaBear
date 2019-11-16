using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton2 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num2 > 0)
        {
            GetComponentInParent<Safe>().num2--;
        }
        else
        {
            GetComponentInParent<Safe>().num2 = 9;
        }

    }
}
