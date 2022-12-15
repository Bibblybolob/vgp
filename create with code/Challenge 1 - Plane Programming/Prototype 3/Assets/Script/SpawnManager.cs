using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(25,0,0);
    private float startDelay = 2;
    private float repeatDelay = 2;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, repeatDelay);
        PlayerControllerScript = 
        GameObject.Find("Player").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomObstacle()
    {
        if (PlayerControllerScript.gameOver ==false)
        {
        int objectIndex = Random.Range(0, obstaclePrefabs.Length);
        Instantiate(obstaclePrefabs[objectIndex], spawnPos, obstaclePrefabs[objectIndex].transform.rotation);
        }
    }
}
