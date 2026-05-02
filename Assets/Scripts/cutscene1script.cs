using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene1script : MonoBehaviour
{
    public float timer;

    public int[] indexvalfadeblack;
    public int[] indexvalfadewhite;
    public int[] indexvalfadeout;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if(this.gameObject.tag == "ViewBlocker")
        {
            foreach(int i in indexvalfadewhite){
                if(GameObject.Find("DIalouge Box").GetComponent<diascript>().index == i && timer > .02f){
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.GetComponent<SpriteRenderer>().color.r + .05f, gameObject.GetComponent<SpriteRenderer>().color.g + .05f, gameObject.GetComponent<SpriteRenderer>().color.b + .05f, 1);
                    timer = 0;
                }
            }
            foreach(int i in indexvalfadeblack){
                if(GameObject.Find("DIalouge Box").GetComponent<diascript>().index == i && timer > .02f)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.GetComponent<SpriteRenderer>().color.r - .05f, gameObject.GetComponent<SpriteRenderer>().color.g - .05f, gameObject.GetComponent<SpriteRenderer>().color.b - .05f, 1);
                    timer = 0;
                }
            }
            foreach(int i in indexvalfadeout){
                if(GameObject.Find("DIalouge Box").GetComponent<diascript>().index == i && timer > .02f)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().color = new Color(gameObject.GetComponent<SpriteRenderer>().color.r - .05f, gameObject.GetComponent<SpriteRenderer>().color.g - .05f, gameObject.GetComponent<SpriteRenderer>().color.b - .05f, gameObject.GetComponent<SpriteRenderer>().color.a - .05f);
                    timer = 0;
                }
            }
        }
    }
}
