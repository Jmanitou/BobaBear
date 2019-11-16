using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton3 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num3 < 9)
        {
            GetComponentInParent<Safe>().num3++;
        }
        else
        {
            GetComponentInParent<Safe>().num3 = 0;
        }

    }
}
