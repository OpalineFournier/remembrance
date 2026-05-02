using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcher : MonoBehaviour
{
    [System.Serializable]
    public class changewithspriteatindex
    {
        public Sprite sprite;
        public int index;
        public Vector3 scalesize;
    }
    public changewithspriteatindex[] changewithspriteAatindexA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    /*
        if(changewithspriteAatindexA.scalesize[i] == new Vector3(0f, 0f, 0f))
        {
            changewithspriteAatindexA.scalesize[i] = this.gameObject.GetComponent<Transform>().scale;
        }
        */
    }

}
