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
    
    public int activeindex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("BlinkingSquare").GetComponent<blinkingscript>().eyesclosed)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = this.gameObject.GetComponent<SpriteSwitcher>().changewithspriteAatindexA[activeindex].sprites;
            if(changewithspriteAatindexA[activeindex].scalesize != new Vector3(0f, 0f, 0f))
            {
                this.gameObject.transform.localScale = changewithspriteAatindexA[activeindex].scalesize;
            }

        }
        
    }

}
