using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private  SpawnStone spawnStone;

    private float spawnRate = 1.0f;
    private float nextSpawn = 0.0f;

    [SerializeField]
    private CloudMovement m_cloudController;

    [SerializeField]
    //private ToolChange m_toolChangeController;
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.X) && Time.time > nextSpawn)
        {
            if(spawnStone)
            {
            spawnStone.Spawn();
            }
            nextSpawn = Time.time + spawnRate;         
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {

            m_cloudController.Action();
        }

    }
   
}
