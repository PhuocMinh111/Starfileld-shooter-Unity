using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New Wave Config")]
public class WaveConfigSo : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField] Transform pathPrefab;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] List<GameObject> enemyList;
    [SerializeField] private float movSpeed = 7f;

    public Transform GetStartingPoint()
    {
        return pathPrefab.GetChild(0);
    }



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
    // public List<GameObject> GetenemyList() {
    //     List<GameObject> enemyList;


    // }
    public int GetEnemyCount()
    {
        return enemyList.Count;
    }
    public GameObject GetEnemyPrefab(int index)
    {
        return enemyList[index];
    }

}
