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
    public PickOrZoom pickupOrZoom;
    public bool zoomedIn;
    public bool pickedUp;
    //reference to Player script
    private Inventory player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Inventory>();
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
        for (int i=0; i<player.inventory.Count; i++)
        {
            if (player.isFull[i] == false)
            {
                pickedUp = true;
                player.inventory.Add(this);
                Instantiate(player.item, player.inventory[i].transform, false);
                gameObject.SetActive(false);
                break;
            }
        }
    }

    void Dropped()
    {
        pickedUp = false;
        player.inventory.Remove(this);
        gameObject.SetActive(true);
    }

    private void OnMouseDown()
    {
        if (pickupOrZoom == PickOrZoom.pick)
        {
            PickUp();
        }
        else if (pickupOrZoom == PickOrZoom.zoom)
        {
            if (zoomedIn)
            {
                UnZoom();
            }
            else
            {
                Zoom();
            }
        }
    }
}
