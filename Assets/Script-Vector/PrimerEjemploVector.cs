using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerEjemploVector : MonoBehaviour
{
    public Transform spawn;
    public float dot = 0.0f;
    public Color linecolor = Color.white;

    private void Update()
    {
        dot = Vector3.Dot(transform.right.normalized, spawn.transform.right.normalized);
        if (dot <-0.998) 
        {
            linecolor = Color.black;
        }

        else 
        {
            linecolor = Color.yellow; 

        }

        Debug.DrawRay(transform.position, transform.right.normalized, linecolor);
        Debug.DrawRay(spawn.transform.position, spawn.transform.right.normalized, linecolor);

    }
}
