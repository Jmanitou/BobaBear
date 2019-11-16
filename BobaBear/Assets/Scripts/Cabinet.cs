using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : Object
{
    bool closed;
    List<Object> inventory;

    // Start is called before the first frame update
    void Start()
    {
        zoomedIn = true;
        pickupOrZoom = PickOrZoom.zoom;

        //Reference to player inventory to check for key
        inventory = GameObject.Find("Player").GetComponent<Inventory>().inventory;
    }

    // Update is called once per frame
    void Update()
    {
        if (zoomedIn)
        {
            OpenCabinet();
        }
    }

    void OpenCabinet()
    {
        // if key is selected/if key is dragged and dropped over cabinet
        if (true)
        {

        }
    }
}
