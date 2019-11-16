using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton3 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num3 > 0)
        {
            GetComponentInParent<Safe>().num3--;
        }
        else
        {
            GetComponentInParent<Safe>().num3 = 9;
        }

    }
}
