using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangerNew : MonoBehaviour
{
    public int numOfMaterials;
    public Material materialOne;
    public Material materialTwo;
    public Material materialThree;
    public Material materialFour;
    public Material materialFive;
    public Material materialSix;
    public Material materialSeven;
    public Material materialEight;
    public Material materialNine;
    public Material materialTen;
    public Material materialEleven;
    public Material materialTwelve;
    public Material materialThirteen;
    public Material materialFourteen;

    public float timer;
    public int cd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Renderer objectRenderer = GetComponent<Renderer>();

        if (timer >= cd)
        {
            int randomNumber = Random.Range(0, numOfMaterials);

            if (randomNumber < 1)
                objectRenderer.material = materialOne;
            else if (randomNumber < 2)
                objectRenderer.material = materialTwo;
            else if (randomNumber < 3)
                objectRenderer.material = materialThree;
            else if (randomNumber < 4)
                objectRenderer.material = materialFour;
            else if (randomNumber < 5)
                objectRenderer.material = materialFive;
            else if (randomNumber < 6)
                objectRenderer.material = materialSix;
            else if (randomNumber < 7)
                objectRenderer.material = materialSeven;
            else if (randomNumber < 8)
                objectRenderer.material = materialEight;
            else if (randomNumber < 9)
                objectRenderer.material = materialNine;
            else if (randomNumber < 10)
                objectRenderer.material = materialTen;
            else if (randomNumber < 11)
                objectRenderer.material = materialEleven;
            else if (randomNumber < 12)
                objectRenderer.material = materialTwelve;
            else if (randomNumber < 13)
                objectRenderer.material = materialThirteen;
            else if (randomNumber < 14)
                objectRenderer.material = materialFourteen;

            timer = 0;
        }
    }
}
