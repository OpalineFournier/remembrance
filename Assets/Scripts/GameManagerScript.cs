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
    //Pause Menu variables (WIP)

    public bool ispaused;
    
    public GameObject pausemenu;
    public GameObject pausemenuprefab;

    public Animator pauseAnimator;

    public GameObject sensslider;
    // Start is called before the first frame update
    void Start()
    {
        permittedcammove = true;
        noteUp = true;
        note.SetActive(true);
        seated = false;
        newstop = false;
        this.gameObject.GetComponent<experimentalaudio>().audiomanager("music", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Note (PLEASE NOTE THIS IS NOT THE CANVAS. DO NOT DISABLE THE CANVAS)
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
        //Pause Menu
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(ispaused && pausemenu != null){
                ispaused = false;
            }
            else if(!ispaused && pausemenu == null){
                ispaused = true;
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

        //pause menu stuff
        if(ispaused && pausemenu == null)
        {
            permittedcammove = false;
            pausemenu = Instantiate(pausemenuprefab, GameObject.Find("Note (1)").GetComponent<Transform>());
            pauseAnimator = GameObject.Find("PauseMenu(Clone)").GetComponent<Animator>();
            pauseAnimator.SetBool("ifsettings", false);
        }
        else if(!ispaused && pausemenu != null)
        {
            permittedcammove = true;
            pauseAnimator.SetBool("ifsettings", true);
            if(pauseAnimator.GetCurrentAnimatorStateInfo(0).IsName("trueAway"))
            {
                Destroy(pausemenu);
            }
        }
    }
    public void spawnObject()
    {
        Instantiate(sensslider);
    }
}
