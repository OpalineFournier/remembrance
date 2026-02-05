using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public int numOfMaterials;

    public Material materialOne;
    public Material materialTwo;
    public Material materialThree;
    public Material materialFour;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Renderer objectRenderer = GetComponent<Renderer>();

        int randomNumber = Random.Range(0, numOfMaterials);

        if (randomNumber < 1)
            objectRenderer.material = materialOne;
        else if (randomNumber < 2)
            objectRenderer.material = materialTwo;
        else if (randomNumber < 3)
            objectRenderer.material = materialThree;
        else if (randomNumber < 4)
            objectRenderer.material = materialFour;
    }
}
