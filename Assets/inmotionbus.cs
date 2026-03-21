using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inmotionbus : MonoBehaviour
{
    private Animator thisanim;

    public AudioClip clip;
    public AudioSource source;

    public int bustravelatindex;
    // Start is called before the first frame update
    void Start()
    {
        thisanim = this.gameObject.GetComponent<Animator>();
        source = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bustravelatindex == GameObject.Find("DIalouge Box").GetComponent<diascript>().index)
        {
            thisanim.SetBool("inmotion", true);
            source.PlayOneShot(clip);
            bustravelatindex++;
        }
    }
}
