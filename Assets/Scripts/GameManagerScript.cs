using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject note;
    public bool noteUp;

    public int forgetStage;
    public float timerF;

    public bool seated;
    public float timerS;

    public bool atDest;

    public bool driving;

    public bool newstop;

    public bool permittedcammove;
    // Start is called before the first frame update
    void Start()
    {
        permittedcammove = true;
        noteUp = false;
        note.SetActive(true);
        seated = false;
        newstop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (noteUp == false)
            {
                noteUp = true;
                note.SetActive(true);
            }
            else if (noteUp == true)
            {
                noteUp = false;
                note.SetActive(false);
                timerF = 0;
            }
        }

        if (seated)
        {
            timerS += Time.deltaTime;

            if (timerS >= 5)
            {
                seated = false;
                atDest = true;
            }
        }
        else
        {
            timerF += Time.deltaTime;

            if (timerF < 5)
            {
               forgetStage = 0;
            }
            else if (timerF < 10)
            {
                forgetStage = 1;
            }
            else if (timerF < 15)
            {
                forgetStage = 2;
            }
            else if (timerF < 20)
            {
                forgetStage = 3;
            }
        }

        if (!atDest)
        {
            newstop = true;
        }
    }
}
