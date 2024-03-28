using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float suctionSpeed = 5f; 
    public Transform player; 
    public float minDistance = 0.1f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (player != null)
        {
            Vector3 directionToPlayer = player.position - transform.position;

            float distanceToPlayer = directionToPlayer.magnitude;


            if (distanceToPlayer > minDistance)
            {
                Vector3 moveDirection = directionToPlayer.normalized * suctionSpeed * Time.deltaTime;

                transform.position += moveDirection;
            }
        }
    }

}
