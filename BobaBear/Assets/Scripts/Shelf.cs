﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : Object
{
    public Object key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        if (player.inventory.Contains(key))
        {

        }
        else
        {
            base.OnMouseDown();
        }
    }
}
