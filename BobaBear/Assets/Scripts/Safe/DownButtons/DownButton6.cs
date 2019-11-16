using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton6 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num6 > 0)
        {
            GetComponentInParent<Safe>().num6--;
        }
        else
        {
            GetComponentInParent<Safe>().num6 = 9;
        }

    }
}
