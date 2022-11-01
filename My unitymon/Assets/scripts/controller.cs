using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");
        //print(transform.position);

        if (Input.GetKey(KeyCode.W))
        {
            //print("hello");

            //transform.position = new Vector3(0, 2, 0);
            transform.position = new Vector3(0, transform.position.y + 0.005f, 0);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            //transform.position = new Vector3(0, -2, 0);
            transform.position = new Vector3(0, transform.position.y - 0.005f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.position = new Vector3(2, 0, 0);

            transform.position = new Vector3(transform.position.x + 0.005f, 0, 0);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            //transform.position = new Vector3(-2, 0, 0);
            transform.position = new Vector3(transform.position.x - 0.005f, 0, 0);
            //transform.position = new Vector3(transform.position.x -0.005f, transform.position.y - 0.005f, 0);
        }

       
        {

        }

    }
}
