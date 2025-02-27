using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitdamage : MonoBehaviour
{
    
    SpriteRenderer SpriteRenderer;
    public Color hitColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(SpriteRenderer.color);
        SpriteRenderer.color = hitColor;  
    }
    void OnCollisionStay2D(Collision2D collision)
    {
         Debug.Log(SpriteRenderer.color);
        SpriteRenderer.color = hitColor;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        SpriteRenderer.color = Color.white;
    }

}
