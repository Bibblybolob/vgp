using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerController PlayerControllerScript;
    private float leftBound = -15;  
    public bool gameOver = false;
    // Start is called before the first frame update

    void Start()
    {
        PlayerControllerScript = 
        GameObject.Find("Player").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && !gameOver)
        {
            speed = 30+30;
        }
        if (PlayerControllerScript.gameOver ==false)
        {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
