﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //camera variables
    public Camera cam;
    public float camSpeed;
    public float leftLimit;
    public float rightLimit;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        CameraMove();
    }
    
    //Panning the camera left and right only
    void CameraMove()
    {
        Vector3 pos = cam.transform.position;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (pos.x > leftLimit)
            {
                pos.x -= camSpeed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (pos.x < rightLimit)
            {
                pos.x += camSpeed * Time.deltaTime;
            }
        }
        cam.transform.position = pos;
    }
    
}
