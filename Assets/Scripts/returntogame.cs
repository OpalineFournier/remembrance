using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returntogame : MonoBehaviour
{
    public GameObject gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void returngame()
    {
        if(gamemanager.GetComponent<GameManagerScript>().ispaused && gamemanager.GetComponent<GameManagerScript>().pausemenu != null){
            gamemanager.GetComponent<GameManagerScript>().ispaused = false;
        }
        else if(!gamemanager.GetComponent<GameManagerScript>().ispaused && gamemanager.GetComponent<GameManagerScript>().pausemenu == null){
            gamemanager.GetComponent<GameManagerScript>().ispaused = true;
        }
    }
}
