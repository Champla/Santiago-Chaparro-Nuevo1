using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundovecotres : MonoBehaviour
{
    float scl = 1.1f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.localScale *= scl;

        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) 
        {
            transform.localScale /= scl;
        }
    }
}
