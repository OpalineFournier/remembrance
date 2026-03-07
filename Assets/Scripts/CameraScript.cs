using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour

{
    public Transform player;
    public Transform playerCam;
    public float mouseSensitivity = 100f;
    public float xRot = 0f;
    public float minY = -90f;
    public float maxY = 90f;
    public bool canmovecam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerCam.position;
        canmovecam = GameObject.Find("GameManager").GetComponent<GameManagerScript>().permittedcammove;
        if(canmovecam){
            MouseLook();
        }
    }
    void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minY, maxY);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        player.Rotate(Vector3.up * mouseX);

    }

}
