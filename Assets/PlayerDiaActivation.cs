using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDiaActivation : MonoBehaviour
{
    public GameObject Dia;
    public GameObject Dia2;
    public Transform playerCam;
    public GameObject Player;
    public bool noteUp;
    // Start is called before the first frame update
    void Start()
    {
        playerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        Dia.SetActive(false);
        Dia2.SetActive(false);

        noteUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            if (noteUp == true)
            {
                noteUp = false;
            }
            else if (noteUp == false)
            {
                noteUp = true;
            }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Character")
        {
            if(noteUp == true)
            {
                Dia.SetActive(true);
            }

            if(noteUp == false)
            {
                Dia2.SetActive(true);
            }

        }
       



    }
}
