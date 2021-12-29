using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PlayerOneScript : MonoBehaviour
{
    private BaseInput bi;
    private Rigidbody2D _playerRigidBody;
    public int speed = 12;

    private void awake() {
        _playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void OnGUI()
    {
        Event e = Event.current;
        giveMovement(e);
    }
    void giveMovement() {
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

    bool move(KeyCode direcction) {
        switch (direcction) {
            case KeyCode.A:
                Debug.Log("Letter A is pressed");
                float moveVertical = Input.GetAxisRaw("Vertical");

                movement = new Vector2(0f, moveVertical);
                movement = movement * speed * Time.deltaTime;

                _playerRigidBody.MovePosition(transform.position + movement);
                return true;
            case KeyCode.D:
                Debug.Log("Letter D is pressed");
                Debug.Log("Letter A is pressed");
                float moveVertical = Input.GetAxisRaw("Vertical");

                movement = new Vector2(0f, moveVertical);
                movement = movement * (-1 * speed) * Time.deltaTime;

                _playerRigidBody.MovePosition(transform.position + movement);
                return true;
            default:
                return false;
        }
    }

}
