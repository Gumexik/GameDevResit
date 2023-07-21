using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] m_SpawnPoints;
    public GameObject m_enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < m_SpawnPoints.Length; i++) {

            SpawnNewEnemy(i);
            
        }
    }

   


    void SpawnNewEnemy(int points) {
        Instantiate(m_enemyPrefab, m_SpawnPoints[points].transform.position, Quaternion.identity);
    }
}
