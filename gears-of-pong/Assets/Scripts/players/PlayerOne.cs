using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PlayerOneScript : MonoBehaviour
{
    private BaseInput bi;
    private Rigidbody2D rb;

    private void awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        bool isMousePresent = bi.mousePresent;
        if (isMousePresent) { 
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
