using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    public List<Vector3> Waypoints;

    public bool isLooped;

    void Awake()
    {
        Waypoints.Add(transform.position);
        Waypoints.Add(GameObject.Find("1").GetComponent<Transform>().position);
        Waypoints.Add(GameObject.Find("2").GetComponent<Transform>().position);
        Waypoints.Add(GameObject.Find("3").GetComponent<Transform>().position);
        Waypoints.Add(GameObject.Find("4").GetComponent<Transform>().position);
    }

    void Start()
    {

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Waypoints[1], Waypoints[2]);
        Gizmos.DrawLine(Waypoints[2], Waypoints[3]);
        Gizmos.DrawLine(Waypoints[3], Waypoints[4]);

        if (isLooped == true)
        {
            Gizmos.DrawLine(Waypoints[4], Waypoints[1]);
        }

        Gizmos.color = Color.cyan;
        for (int i = 0; i <= 4; i++)
        {


            Gizmos.DrawSphere(Waypoints[i], 1);


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
