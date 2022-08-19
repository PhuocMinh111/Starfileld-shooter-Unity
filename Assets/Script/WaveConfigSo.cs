using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class WaveConfigSo : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField] Transform pathPrefab;
    GameObject enemyPrefab;
    [SerializeField] List<GameObject> enemyList;
    [SerializeField] private float movSpeed = 7f;
    [SerializeField] float timeBetween = 1f;
    [SerializeField] float spawnTimeVariant = 0f;
    [SerializeField] float minSpawnTime = 0.2f;




    public List<Transform> GetTransforms()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach (Transform pos in pathPrefab)
        {
            waypoints.Add(pos);
        }
        return waypoints;
    }

    public float GetMovSpd()
    {
        return movSpeed;
    }
    public int GetEnemyCount()
    {
        return enemyList.Count;
    }


    public GameObject GetEnemyPrefab(int index)
    {
        return enemyList[index];
    }

    public Transform GetStartingPoint()
    {
        return pathPrefab.GetChild(0);
    }

    public float GetRandomSpawnTime()
    {
        float spawnTime = Random.Range(timeBetween - spawnTimeVariant,
                                        timeBetween + spawnTimeVariant);
        return Mathf.Clamp(spawnTime, minSpawnTime, float.MaxValue);
    }
}
