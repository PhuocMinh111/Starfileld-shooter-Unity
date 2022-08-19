using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] WaveConfigSo waveConfig;
    List<Transform> waypoints;
    EnemySpawner enemySpawner;
    int waveIndex = 0;

    void Awake()
    {
        enemySpawner = FindObjectOfType<EnemySpawner>();
    }


    void Start()
    {
        waveConfig = enemySpawner.GetCurrentWave();
        waypoints = waveConfig.GetTransforms();
        transform.position = waypoints[waveIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPath();
    }



    void FollowPath()
    {
        if (waveIndex < waypoints.Count)
        {
            Vector3 targerPos = waypoints[waveIndex].position;
            float delta = waveConfig.GetMovSpd() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targerPos, delta);
            if (transform.position == targerPos)
            {
                waveIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
