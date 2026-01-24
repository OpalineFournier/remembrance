using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatScript : MonoBehaviour
{
    public float destX;
    public float destY;
    public float destZ;

    public GameObject player;

    public GameObject gameManagerObject;
    public GameManagerScript gameManagerScript;

    public bool sat = false;

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
            if (!sat)
            {
                sat = true;
                player.transform.position = new Vector3(destX, destY, destZ);
                gameManagerScript.seated = true;
            }
        }
    }
}
