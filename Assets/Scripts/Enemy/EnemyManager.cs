using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] m_SpawnPoints;
    public GameObject m_enemyPrefab;

    private float enemyNumber = 15f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < enemyNumber; i++) {
            SpawnNewEnemy();
        }
    }

   


    void SpawnNewEnemy() {
        Instantiate(m_enemyPrefab, m_SpawnPoints[0].transform.position, Quaternion.identity);
    }
}
