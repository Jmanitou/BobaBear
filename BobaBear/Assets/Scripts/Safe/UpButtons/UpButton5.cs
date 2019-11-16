using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton5 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num5 < 9)
        {
            GetComponentInParent<Safe>().num5++;
        }
        else
        {
            GetComponentInParent<Safe>().num5 = 0;
        }

    }
}
