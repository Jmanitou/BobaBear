using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectSequence : MonoBehaviour
{
    public List<Object> chemicals;
    // Start is called before the first frame update
    void Start()
    {
        chemicals = new List<Object>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddList(Object chemical)
    {
        chemicals.Add(chemical);
    }

    void Test()
    {
        int count = 0;
        foreach (TestTube chemical in chemicals)
        {
            if (chemical.name == "Water" || chemical.name == "Nitrogen Dioxide")
            {
                count++;
            }
        }
        if (count == 2)
        {
            //whatever happens when you get the chemical
        }
    }
}
