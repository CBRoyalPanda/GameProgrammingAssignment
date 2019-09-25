using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisable : MonoBehaviour
{
    public GameObject SpaceShip;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Disable Ship
        if (Input.GetKeyDown(KeyCode.Q))
        {
           
            SpaceShip.SetActive(false);
        }
            
        
    }
}
