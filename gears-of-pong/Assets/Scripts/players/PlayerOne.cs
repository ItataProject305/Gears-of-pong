using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    private BaseInput bi;
    private Rigidbody2D rb2D;
    private int speed = 12;
    private Vector2 velocity = new Vector2(0f, 10f);
    private Vector2 _direction = new Vector2(0f, 0f); 

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();

        checkInput();
    }

    private void checkInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _direction = new Vector2(0f, 10f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = new Vector2(0f, -10f);
        } else 
        {
            _direction = new Vector2(0f, 0f);
        }
    }

    private void move()
    {
        rb2D.velocity = _direction * speed * Time.deltaTime;
    }

}
