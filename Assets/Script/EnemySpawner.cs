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
        StartCoroutine(SpawnEnemy());
    }


    public WaveConfigSo GetCurrentWave()
    {
        return currentWave;
    }


    IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < currentWave.GetEnemyCount(); i++)
        {
            // instatiate new enemy   
            Instantiate(currentWave.GetEnemyPrefab(i),
                        currentWave.GetStartingPoint().position,
                        Quaternion.identity,
                        transform);
            yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());
        }
    }


    // Update is called once per frame

}
