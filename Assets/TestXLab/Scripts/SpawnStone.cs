using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    [SerializeField]
    private GameObject[] m_stonePrefab;


    public void Spawn()
    {

        int index = Random.Range(0, m_stonePrefab.Length);
        var stone = Instantiate(m_stonePrefab[index], transform.position, transform.rotation);
        
        Destroy(stone,5.0f);

        
    }
}
