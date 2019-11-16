using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public Vector2 position;
    public float scaleX;
    public float scaleY;
    public float scaleZ;
    public bool pickupable;
    public bool pickedUp;
    Player player = GameObject.Find("Player").GetComponent<Player>();

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        pickedUp = false;
        position = gameObject.transform.position;
        scaleX = gameObject.transform.localScale.x;
        scaleY = gameObject.transform.localScale.y;
        scaleZ = gameObject.transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Zoom()
    {
        gameObject.transform.position = new Vector3(0,0,0);
        //gameObject.transform.localScale = new Vector3(5,5,0); change later
    }

    void UnZoom()
    {
        gameObject.transform.position = position;
        gameObject.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
    }

    void PickUp()
    {
        player.inventory.Add(this);
        GetComponent<MeshRenderer>().enabled = false;
        gameObject.SetActive(false);

    }
}
