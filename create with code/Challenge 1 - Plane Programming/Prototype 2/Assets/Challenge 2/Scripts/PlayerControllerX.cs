using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogshoot = 1; 
    private float Cooldown = 0;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > dogshoot)
        {
            Cooldown = Time.time + dogshoot;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
