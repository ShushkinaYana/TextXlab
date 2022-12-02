using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    [SerializeField]
    private GameObject m_stonePrefab;

    private float spawnRate = 1.0f;
    private float nextSpawn = 0.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && Time.time > nextSpawn)
        {
            Spawn();
            nextSpawn = Time.time + spawnRate;            
        }

    }

    void Spawn()
    {
        var stone = Instantiate(m_stonePrefab);
        Destroy(stone,6.0f);
    }
}
