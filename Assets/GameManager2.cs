using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    void Start()
    {
        // Ensure the cursor is visible and unlocked when the game starts (optional)
        EnableCursor();
    }

    // A public method to be called from other scripts or UI buttons to enable the cursor
    public void EnableCursor()
    {
        Cursor.visible = true; // Makes the cursor graphic visible
        Cursor.lockState = CursorLockMode.None; // Allows the cursor to move freely within the window
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
