using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false); // Deactivate the object with the "Red" tag when 'i' is 100
        }
        else if (gameObject.CompareTag("Blue") && i == Random.Range(150, 251))
        {
            rend.enabled = false; // Disable the renderer of the object with the "Blue" tag with a random 'i' value
        }
    }
}
