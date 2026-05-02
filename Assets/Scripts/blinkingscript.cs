using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinkingscript : MonoBehaviour
{
    public float timer;

    public GameObject box;
    public bool eyesclosed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TO ONLY BE USED IN CUTSCENES THAT REQUIRE A ANIMATION OF THE SORTS
    }
    public void blink()
    {
        StartCoroutine(blinkandunblink());
    }
    IEnumerator blinkandunblink()
    {
        bool blinked = false;
        while(!blinked)
        {
            if(!eyesclosed)
            {
                box.GetComponent<SpriteRenderer>().color = new Color(box.GetComponent<SpriteRenderer>().color.r, box.GetComponent<SpriteRenderer>().color.g, box.GetComponent<SpriteRenderer>().color.b, box.GetComponent<SpriteRenderer>().color.a + .15f);
                if(box.GetComponent<SpriteRenderer>().color.a >= .99f)
                {
                    eyesclosed = true;
                }
                yield return new WaitForSeconds(.03f);
            }
            if(eyesclosed)
            {
                box.GetComponent<SpriteRenderer>().color = new Color(box.GetComponent<SpriteRenderer>().color.r, box.GetComponent<SpriteRenderer>().color.g, box.GetComponent<SpriteRenderer>().color.b, box.GetComponent<SpriteRenderer>().color.a - .15f);
                if(box.GetComponent<SpriteRenderer>().color.a <= .01f)
                {
                    eyesclosed = false;
                    blinked = true;
                }
                yield return new WaitForSeconds(.03f);
            }
        }
        
    }
}
