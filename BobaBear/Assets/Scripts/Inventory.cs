using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Object> inventory;
    public GameObject[] slots;
    public bool[] isFull;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<Object>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
