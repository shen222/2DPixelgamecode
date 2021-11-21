using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointintIndex = 0;

    [SerializeField] private float speed = 2f;
     
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointintIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointintIndex++;
            if (currentWaypointintIndex >= waypoints.Length)
            {
                currentWaypointintIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointintIndex].transform.position, Time.deltaTime * speed);
    }
}
