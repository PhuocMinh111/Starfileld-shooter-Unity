using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] WaveConfigSo currentWave;

    private void Awake()
    {

    }
    void Start()
    {
        SpawnEnemy();
    }
    public WaveConfigSo GetCurrentWave()
    {
        return currentWave;
    }
    void SpawnEnemy()
    {
        // GameObject enemy = new GameObject();
        Instantiate(currentWave.GetEnemyPrefab(0),
                    currentWave.GetStartingPoint().position,
                    Quaternion.identity);
    }


    // Update is called once per frame

}
