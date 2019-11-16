using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton4 : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GetComponentInParent<Safe>().num4 < 9)
        {
            GetComponentInParent<Safe>().num4++;
        }
        else
        {
            GetComponentInParent<Safe>().num4 = 0;
        }

    }
}
