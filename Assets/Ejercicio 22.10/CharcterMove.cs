using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterMove : MonoBehaviour
{
    public float Speed = 5.0f;
    public float Speedr = 200.0f;
    public Rigidbody rb;
    public float JumpForce = 8f;
    public bool puedoSaltar;

    private Animator anim;
    public  float x,y;
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * Speedr, 0);
        transform.Translate(0, 0, y * Time.deltaTime * Speed);
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
              

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (puedoSaltar) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                anim.SetBool("Salte",true);
                rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else 
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("salte", false);
    }
}
