using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    public Material materialOne;
    public Material materialTwo;
    public Material materialThree;
    public Material materialFour;

    public GameObject gameManagerObject;
    public GameManagerScript gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = gameManagerObject.GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Renderer objectRenderer = GetComponent<Renderer>();

        if (gameManagerScript.forgetStage == 0)
            objectRenderer.material = materialOne;
        else if (gameManagerScript.forgetStage == 1)
            objectRenderer.material = materialTwo;
        else if (gameManagerScript.forgetStage == 2)
            objectRenderer.material = materialThree;
        else if (gameManagerScript.forgetStage == 3)
            objectRenderer.material = materialFour;
    }
}
