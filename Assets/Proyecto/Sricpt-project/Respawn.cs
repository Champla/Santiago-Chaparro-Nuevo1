using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
        public Transform player;
        public Transform respawnPoint;

        // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            player.transform.position = respawnPoint.transform.position;
        }

   
}
