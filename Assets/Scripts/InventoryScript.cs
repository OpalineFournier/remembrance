using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public GameObject canvas;
    public GameObject[] inventoryslots;

    public bool invopened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I) && !invopened){
            invopened = true;
            for(int i = 0; i < inventoryslots.Length; i++){
                Instantiate(inventoryslots[i], canvas.transform);
            }
            
        }
        else if(Input.GetKeyDown(KeyCode.I) && invopened) {
            invopened = false;
            foreach(Transform objectsincanvas in canvas.transform){
                if(objectsincanvas.CompareTag("InvSlot")){
                    Destroy(objectsincanvas.gameObject);
                }
            }
        }
    }
}