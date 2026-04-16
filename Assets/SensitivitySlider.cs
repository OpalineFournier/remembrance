using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivitySlider : MonoBehaviour
{
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
}
