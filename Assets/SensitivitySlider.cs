using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivitySlider : MonoBehaviour
{
    public GameObject sensslide;
    // Start is called before the first frame update
    void Start()
    {
       this.gameObject.GetComponent<Slider>().value = GameObject.Find("PlayerCamera").GetComponent<CameraScript>().mouseSensMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("PlayerCamera").GetComponent<CameraScript>().mouseSensMultiplier = this.gameObject.GetComponent<Slider>().value;
    }
    public void spawnobj()
    {
        if(!(GameObject.Find("Slider(Clone)")))
        {
            Instantiate(sensslide, GameObject.Find("PauseMenu(Clone)").GetComponent<Transform>());
        }
        else
        {
            Destroy(GameObject.Find("Slider(Clone)"));
        }
    }
}
