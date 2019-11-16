using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton5 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num5 > 0)
        {
            GetComponentInParent<Safe>().num5--;
        }
        else
        {
            GetComponentInParent<Safe>().num5 = 9;
        }

    }
}
