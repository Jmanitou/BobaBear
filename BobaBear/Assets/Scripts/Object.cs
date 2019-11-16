using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    //saving position and scale for unZoom
    public Vector2 position;
    public float scaleX;
    public float scaleY;
    public float scaleZ;
    //pickup
    public enum PickOrZoom
    {
        pick,
        zoom
    }
    public bool zoomedIn;
    public bool pickedUp;
    //reference to Player script
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        gameObject.SetActive(true);
        pickedUp = false;
        zoomedIn = false;
        position = gameObject.transform.position;
        scaleX = gameObject.transform.localScale.x;
        scaleY = gameObject.transform.localScale.y;
        scaleZ = gameObject.transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //zooms in on object
    void Zoom()
    {
        zoomedIn = true;
        gameObject.transform.position = new Vector3(0,0,0);
        //gameObject.transform.localScale = new Vector3(5,5,0); change later
    }

    //unZooms
    void UnZoom()
    {
        zoomedIn = false;
        gameObject.transform.position = position;
        gameObject.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
    }

    //picks up an object
    void PickUp()
    {
        pickedUp = true;
        player.inventory.Add(this);
        GetComponent<MeshRenderer>().enabled = false;
        gameObject.SetActive(false);

    }
}
