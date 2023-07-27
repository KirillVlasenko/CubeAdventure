using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public Transform wall;
    public Transform leftPosition;
    public Transform rightPosition;
    public float wallSpeed;
    Vector3 moveDirection= Vector3.right;

    private void Start()
    {
        wall.position = leftPosition.position;
    }

    void Update()
    {
        wall.position += moveDirection * wallSpeed * Time.deltaTime;
        if (wall.position.x > rightPosition.position.x || wall.position.x < leftPosition.position.x)
        {
            moveDirection *= -1;
        }
    }
}
