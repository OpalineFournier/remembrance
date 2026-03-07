using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class experimentalaudio : MonoBehaviour
{
    public GameObject[] npcVoicelines;
    public GameObject[] ambience;
    public GameObject[] music;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void audiomanager(string type, int list)
    {
        if(string.Equals(type, "music"))
        {
            Instantiate(music[list]);
        }
        else if(string.Equals(type, "ambience"))
        {
            Instantiate(ambience[list]);
        }
        else if(string.Equals(type, "voicelines"))
        {
            Instantiate(npcVoicelines[list]);
        }
    }
}
