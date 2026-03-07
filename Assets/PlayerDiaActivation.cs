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
    // Start is called before the first frame update
    void Start()
    {
        playerCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        Dia.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Julissa_NPC")
        {
            Dia.SetActive(true);

        }
        if (collision.gameObject.name == "Julissa_NPC2")
        {
            Dia.SetActive(true);

        }



    }
}
