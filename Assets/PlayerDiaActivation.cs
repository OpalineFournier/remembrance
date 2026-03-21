using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDiaActivation : MonoBehaviour
{
    public GameObject Dia;
    public GameObject Dia2;
    public GameObject Dia3;
    public GameObject Dia4;
    public GameObject Dia5;
    public GameObject Dia6;
    public GameObject Dia7;
    public GameObject Dia8;
    public GameObject Dia9;
    public GameObject Dia10;
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
        if (collision.gameObject.name == "Tutorial_Instruction1")
        {
            Dia2.SetActive(true);

        }


    }
}
