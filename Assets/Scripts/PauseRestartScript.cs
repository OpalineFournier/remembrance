using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseRestartScript : MonoBehaviour
{
    public GameObject[] uiinst;
    public GameObject[] uipref;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(uipref[0] != null){
                Destroy(uipref[0]);
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.Find("GameManager").GetComponent<GameManagerScript>().permittedcammove = true;
            }
            else{
               uipref[0] = Instantiate(uiinst[0], GameObject.Find("Note").GetComponent<Transform>());
               Cursor.lockState = CursorLockMode.None;
               GameObject.Find("GameManager").GetComponent<GameManagerScript>().permittedcammove = false;
            }
        }
    }
}
