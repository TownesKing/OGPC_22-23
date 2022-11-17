using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit : MonoBehaviour
{

    Vector3 up = Vector3.zero;
    Vector3 right = new Vector3(0, 90, 0);
    Vector3 down = new Vector3(0, 180, 0);
    Vector3 left = new Vector3(0, 270, 0);
    Vector3 currentDirection = Vector3.zero;

    Vector3 nextPosition, destination, direction;

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        currentDirection = up;
        nextPosition = Vector3.forward;
        destination = transform.position;
        

    }




    // Update is called once per frame
    void Update()
    {
        Move(); 
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);

        if (Input.GetKeyDown("w"))
        {
            nextPosition = Vector3.forward;
            currentDirection = up;

        }
        if (Input.GetKeyDown("s"))
        {
            nextPosition = Vector3.back;
            currentDirection = down;

        }
        if (Input.GetKeyDown("a"))
        {
            nextPosition = Vector3.left;
            currentDirection = left;

        }
        if (Input.GetKeyDown("d"))
        {
            nextPosition = Vector3.right;
            currentDirection = right;

        }

        if(Vector3.Distance(destination, transform.position) <= 0.01f)
        {
            transform.localEulerAngles = currentDirection;

        }

    }
}
