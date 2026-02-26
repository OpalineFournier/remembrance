using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
   

    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI nameComponent;

    public string[] lines;
    public string[] names;
    public float textSpeed;
    public int index;
    


    // Start is called before the first frame update
    void Start()
    {
 

        textComponent.text = string.Empty;
        startDialogue();
       

  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
   
    }

    void startDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        nameComponent.text = names[index];
    }

    IEnumerator TypeLine()
    {
        nameComponent.text = names[index];
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);

        }

    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }

        else
        {

            gameObject.SetActive(false);
        }
    }
}