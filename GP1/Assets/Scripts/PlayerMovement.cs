using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    // This is the value that determines the speed of the ship
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Whenever the player uses the D key on the keyboard...
        if (Input.GetKey(KeyCode.D))
        {
            // ... then the spite will move to the right
            transform.Translate(Vector2.right*speed*Time.deltaTime);
        }
    }
}
