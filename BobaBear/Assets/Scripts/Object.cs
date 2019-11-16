using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Inventory player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Inventory").GetComponent<Inventory>();
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
        for (int i=0; i<player.slots.Length; i++)
        {
            if (player.isFull[i] == false)
            {
                pickedUp = true;
                player.inventory.Add(this);
                GameObject item = this.transform.GetChild(0).gameObject;
                Image itemImage = item.gameObject.GetComponent<Image>();
                itemImage.rectTransform.anchoredPosition = new Vector2(0, 0);
                Instantiate(itemImage, player.slots[i].transform, false);
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

    public void OnMouseDown()
    {
        if (pickupOrZoom == PickOrZoom.pick)
        {
            Debug.Log("click");
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
