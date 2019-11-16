using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 target;
    public List<Object> inventory;
    private GameObject camera;
    public float camSpeed;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<GameObject>();
        camSpeed = 5.0f;
        inventory = new List<Object>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            
        }
    }
}
