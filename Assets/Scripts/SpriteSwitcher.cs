using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcher : MonoBehaviour
{
    [System.Serializable]
    public class changewithspriteatindex
    {
        public Sprite sprites;
        public int index;
        public Vector3 scalesize;
    }
    public changewithspriteatindex[] changewithspriteAatindexA;
    
    public int indexcount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        indexcount = GameObject.Find("DIalouge Box").GetComponent<diascript>().index;
    }
    public void runswitch()
    {
        for(int i  = 0; i < changewithspriteAatindexA.Length; i++)
        {
            if(indexcount == changewithspriteAatindexA[i].index)
            {
                
                if(GameObject.Find("BlinkingSquare").GetComponent<blinkingscript>().eyesclosed)
                {
                    Debug.Log(i);
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = changewithspriteAatindexA[i].sprites;
                    if(changewithspriteAatindexA[i].scalesize != new Vector3(0f, 0f, 0f))
                    {
                        this.gameObject.transform.localScale = changewithspriteAatindexA[i].scalesize;
                    }
                }
            }
        }
    }
}
