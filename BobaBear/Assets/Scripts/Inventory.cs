using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Object> inventory;
    public List<bool> isFull;
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<Object>(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
