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

    private void awake() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Vector2.up !!");
            _direction = new Vector2(0f, 10f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Vector2.down !!");
            _direction = new Vector2(0f, -10f);
        }
    }

    void OnGUI()
    {
        Event e = Event.current;
        rb2D = GetComponent<Rigidbody2D>();
        //giveMovement(e);
    }
    void giveMovement(Event e) {
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
            
            KeyCode keypress = e.keyCode;
            bool itsMoving = move(keypress);
            if (itsMoving) {
                Debug.Log("The player its moving !!");
            } else {
                Debug.Log("mmmm... the player doesn't move with that key! press A or D key, try it");
            }
        }
    }
    private void Move()
    {
        rb2D.velocity = _direction * speed * Time.deltaTime;
    }
    bool move(KeyCode direcction) {
        switch (direcction) {
            case KeyCode.A:
                rb2D.MovePosition(rb2D.position + (velocity * Time.fixedDeltaTime));
                return true;
            case KeyCode.D:
                rb2D.MovePosition(rb2D.position + ((velocity * -1) * Time.fixedDeltaTime));
                return true;
            default:
                return false;
        }
    }

}
