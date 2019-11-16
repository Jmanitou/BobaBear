using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cabinet : Object
{
    bool open;
    List<Object> inventory;

    // Start is called before the first frame update
    void Start()
    {
        open = false;
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
        if (open)
        {
            //Delete current gameobject and instantiate opened cabinet prefab with object in it
        }
    }

    void OpenCabinet()
    {
        // if key is selected/if key is dragged and dropped over cabinet
        if (true)
        {
            open = true;
        }
    }
}
