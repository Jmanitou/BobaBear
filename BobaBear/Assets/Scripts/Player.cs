using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 target;
    public List<Object> inventory;
    public Camera cam;
    public float camSpeed;
    public float bounds;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        camSpeed = 5f;
        inventory = new List<Object>();
    }

    // Update is called once per frame
    void Update()
    {


        //Panning the camera left and right only
        Vector3 pos = cam.transform.position;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= camSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += camSpeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, bounds, bounds);
        cam.transform.position = pos;
    }
}
