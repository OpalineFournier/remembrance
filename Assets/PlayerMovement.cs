using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(x, 0, z);
        transform.Translate(moveDirection * Time.deltaTime * speed);
    }
}
