using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onawake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Transform>().position += new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
