using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private Vector3 target = new Vector3(-0.863f, -0.42f, 0.782f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target, Vector3.up, 500 * Time.deltaTime);
    }
}
