using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public int numOfSprites;
    public GameObject Jul;
    public Sprite SpriteOne;
    public Sprite SpriteTwo;

    // Start is called before the first frame update
    void Start()
    {
        Jul.GetComponent<SpriteRenderer>().sprite = SpriteOne;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnBecameInvisible()
    {

        int randomNumber = Random.Range(0, numOfSprites);
        Sprite spriteRenderer;
        if (randomNumber < 1)
            Jul.GetComponent<SpriteRenderer>().sprite = SpriteOne;
        else if (randomNumber < 2)
            Jul.GetComponent<SpriteRenderer>().sprite = SpriteTwo;
    }
}
