using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsButton : MonoBehaviour
{
    public GameObject instructions;
    GameObject holder;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && GetComponentInParent<MenuMain>().instructionsOpen == true)
        {
            Destroy(holder);
            GetComponentInParent<MenuMain>().instructionsOpen = false;
        }
    }

    private void OnMouseDown()
    {
        if (GetComponentInParent<MenuMain>().instructionsOpen == false)
        {
            GetComponentInParent<MenuMain>().instructionsOpen = true;
            holder = Instantiate(instructions, new Vector3(0, 0, -5), Quaternion.identity);
        }
    }
}
