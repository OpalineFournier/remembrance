using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene1script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.gameObject.tag == "ViewBlocker")
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.GetComponent<SpriteRenderer>().color.r + 1, gameObject.GetComponent<SpriteRenderer>().color.g + 1, gameObject.GetComponent<SpriteRenderer>().color.b + 1, 1);
        }
    }
}
