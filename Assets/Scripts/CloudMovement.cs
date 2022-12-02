using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CloudMovement : MonoBehaviour
{
    [SerializeField] private Transform c_centr;
    [SerializeField] private float c_speed = 0.02f;
    [SerializeField] private Vector3 axis;

    [SerializeField] ParticleSystem rainParticalSystem;

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            rainParticalSystem.Play();
            Movement();
        }
      
    }

   
    void Movement()
    {
        transform.RotateAround(c_centr.transform.position, axis, c_speed *Time.deltaTime);
    }

}

