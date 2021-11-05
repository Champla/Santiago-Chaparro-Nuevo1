using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColission : MonoBehaviour
{
    public Walk Move;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy") 
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }

}
