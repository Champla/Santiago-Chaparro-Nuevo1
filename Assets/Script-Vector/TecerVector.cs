using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TecerVector : MonoBehaviour
{
    public Transform spawn;
    public Vector3 diff = Vector3.zero;
    public Color lineColor = Color.white;


    private void Update()
    {
        diff = spawn.transform.position - transform.position;

        if (diff.magnitude < 2) 
        {
            lineColor = Color.red;
        }
        else 
        {
            lineColor = Color.cyan;
        }

        Debug.DrawRay(transform.position, diff, lineColor);
    }
}
