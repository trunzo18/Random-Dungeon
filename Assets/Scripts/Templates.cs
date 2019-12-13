using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Templates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    //public GameObject closedRoom;

    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnedBall;
    public GameObject ball;
    

    private void Update()
    {
        if(waitTime <= 0 && spawnedBall == false)
        {
            Instantiate(ball, rooms[rooms.Count - 1].transform.position,Quaternion.identity);
            spawnedBall = true;
        }
        else
        {
            waitTime -= Time.deltaTime;
         }
    }
}