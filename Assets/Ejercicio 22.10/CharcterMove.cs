using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterMove : MonoBehaviour
{
    public float Speed = 5.0f;
    public float Speedr = 200.0f;

    private Animator anim;
    public  float x,y;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * Speedr, 0);
        transform.Translate(0, 0, y * Time.deltaTime * Speed);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
