using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        targetPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[targetPoint].position)
        {
            increaseTargetInt();
        }

        // Move the character towards the target point
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);

        // Calculate the direction to the target point
        Vector3 moveDirection = (patrolPoints[targetPoint].position - transform.position).normalized;

        // If there's a direction to move in, rotate the character to face that direction
        if (moveDirection != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = rotation;
        }
    }

    void increaseTargetInt()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }
}

