using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton6 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num6 < 9)
        {
            GetComponentInParent<Safe>().num6++;
        }
        else
        {
            GetComponentInParent<Safe>().num6 = 0;
        }

    }
}
