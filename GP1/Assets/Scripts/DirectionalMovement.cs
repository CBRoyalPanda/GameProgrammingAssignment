using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMovement : MonoBehaviour

{
    public float lowSpeed = 1.0f;
    public float speed = 10.0f;

    public bool movementDisable = false;

    public GameObject SpaceShip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Basic Directional Movement
        if (movementDisable == false)
        {
            PlayerMovement();
        }


        //Reset Player Position
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector2(0, 0);
        }


        //Quits Program
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        //Disable Movement
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (movementDisable == true)
            {
                movementDisable = false;
            }

            else
            {
                movementDisable = true;
            }
        }
    }

    void PlayerMovement()
    {
        //Moving Up
        if ((Input.GetKey(KeyCode.UpArrow)) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        //Holding shift lowers the speed
        if ((Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.up * lowSpeed * Time.deltaTime);
        }

        //Moving Down
        if ((Input.GetKey(KeyCode.DownArrow)) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        //Holding shift lowers the speed
        if ((Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.down * lowSpeed * Time.deltaTime);
        }

        //Moving Right
        if ((Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        //Holding shift lowers the speed
        if ((Input.GetKey(KeyCode.RightArrow)) && (Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.right * lowSpeed * Time.deltaTime);
        }

        //Moving Left
        if ((Input.GetKey(KeyCode.LeftArrow)) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        //Holding shift lowers the speed
        if ((Input.GetKey(KeyCode.LeftArrow)) && (Input.GetKey(KeyCode.LeftShift)))
        {
            transform.Translate(Vector2.left * lowSpeed * Time.deltaTime);
        }

    }

    }

