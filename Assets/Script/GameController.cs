using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game{
public class GameController : MonoBehaviour
{
    [SerializeField]
    private SpawnStone m_stone;
    private float m_timer = 0f;
    [SerializeField]
    private float m_delay = 1f;

    private void Update()
    {
        m_timer += Time.deltaTime;
        if (m_timer >= m_delay)
        {
            m_stone.Spawn();
            m_timer -= m_delay;
        }
    }
}
}
