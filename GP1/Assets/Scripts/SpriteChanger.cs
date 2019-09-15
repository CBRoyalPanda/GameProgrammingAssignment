using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer theRenderer;
    public Color spriteColor;

    void Start()
    {
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteColor.a = 1.0f;

        if (theRenderer != null)
        {
            theRenderer.color = spriteColor;
        }
        theRenderer.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
