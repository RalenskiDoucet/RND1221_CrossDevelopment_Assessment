using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementBehaviour : MonoBehaviour
{
    public float Speed = 20;

    // Use this for initialization
    void Start()
    {
        Speed *= 500;
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR//In Unity input.
        Rigidbody rb3d = GetComponent<Rigidbody>();
        if (Input.GetButton("Forward"))
            rb3d.AddForce(Vector3.forward * Speed * Time.deltaTime);
        if (Input.GetButton("Backward"))
            rb3d.AddForce(Vector3.back * Speed * Time.deltaTime);
        if (Input.GetButton("Left"))
            rb3d.AddForce(Vector3.left * Speed * Time.deltaTime);
        if (Input.GetButton("Right"))
            rb3d.AddForce(Vector3.right * Speed * Time.deltaTime);

        Input.GetTouch(0);
#else//Andriod system input
        Rigidbody rb3d = GetComponent<Rigidbody>();
        //for (int i = 0; i < Input.touchCount; i++)
        {
            rb3d.AddForce(Vector3.forward * Speed * Time.deltaTime);
        }
        Input.GetTouch(1);
        for (int i = 1; i < Input.touchCount; i++)
        {
            rb3d.AddForce(Vector3.back * Speed * Time.deltaTime);
        }

        Input.GetTouch(2);
        for (int i = 2; i < Input.touchCount; i++)
        {
            rb3d.AddForce(Vector3.left * Speed * Time.deltaTime);
        }

        Input.GetTouch(3);
        for (int i = 3; i < Input.touchCount; i++)
        {
            rb3d.AddForce(Vector3.right * Speed * Time.deltaTime);
        }
#endif
    }
}