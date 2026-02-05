using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camscript : MonoBehaviour
{
    private float xRot;
    private float yRot;
    private float minY;
    private float maxY;
    public Transform playerObject;
    private Transform cameraAnchor;
    public Vector3 offset;
    public bool camlocked;
    // Start is called before the first frame update
    void Start()
    {
        xRot = 0;
        yRot = 0;
        minY = -80;
        maxY = 80;
        playerObject = GameObject.Find("Capsule").transform;
        cameraAnchor = playerObject.Find("CamAncho").transform;
    }

    // Update is called once per frame
    void Update()
    {
        mouseLook();
        transform.position = cameraAnchor.position + playerObject.transform.forward * offset.z + playerObject.transform.up * offset.y;
        if (Input.GetKeyDown(KeyCode.L))
        {
            locktest();;
        }
    }
    void mouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minY, maxY);

        yRot += mouseX;

        playerObject.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRot, playerObject.localRotation.eulerAngles.y, 0);
    }
    void locktest(){
        if(!camlocked){
            Cursor.lockState = CursorLockMode.Locked;
            camlocked = true;
        }
        else{
            Cursor.lockState = CursorLockMode.None;
            camlocked = false;
        }
    }
}
