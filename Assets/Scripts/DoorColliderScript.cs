using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorColliderScript : MonoBehaviour
{
    public float destX;
    public float destY;
    public float destZ;

    public float newDestX;
    public float newDestY;
    public float newDestZ;

    public GameObject player;
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
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (!gameManagerScript.atDest)
                player.transform.position = new Vector3(destX, destY, destZ);
            else if (gameManagerScript.atDest)
                player.transform.position = new Vector3(newDestX, newDestY, newDestZ);
        }
    }
}
