using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public float degreesPerSecond = 20;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) Time.deltaTime)
    }
}
