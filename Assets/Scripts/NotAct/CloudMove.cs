using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CloudMove : MonoBehaviour
{
    [SerializeField] private Transform[] c_position;
    private int c_nextIndex;
    private Transform c_nextPosition;
    [SerializeField] private float c_speed = 15.0f;

    public float angle = 0; // угол 
    public float radius = 0.5f; // радиус
    public bool isCircle = false; // условие движения по кругу

    private bool keyHit = false;
    void Start()
    {
        c_nextPosition = c_position[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Movement();

        }

    }


    void Movement()
    {
        if (transform.position == c_nextPosition.position)
        {
            c_nextIndex++;
            if (c_nextIndex >= c_position.Length)
            {
                c_nextIndex = 0;
            }
            c_nextPosition = c_position[c_nextIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, c_nextPosition.position, c_speed * Time.deltaTime);

        }
    }
}

