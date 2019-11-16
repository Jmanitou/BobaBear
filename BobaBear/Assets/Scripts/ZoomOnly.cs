using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOnly : Object
{
    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
        pickupOrZoom = PickOrZoom.zoom;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(image, new Vector3(0, 0, -4), Quaternion.identity);
    }

}
