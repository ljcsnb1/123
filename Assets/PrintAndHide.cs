using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3; // Initialize 'i' to 3
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;
        if (i == 100)
        {
            rend.enabled = false; // Hide the renderer when 'i' reaches 100
        }
    }
}
