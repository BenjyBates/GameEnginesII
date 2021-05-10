using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBoid : MonoBehaviour
{

    public GameObject Prefab;
    public GameObject goal;
    public Transform spawn;
    public static float WorldSize = 50;
    public static float WorldSizeX;
    public static float WorldSizeY;
    public static float WorldSizeZ;

    public static Vector3 goalPos = Vector3.zero;

    static int CrowdSize = 100;
    public static GameObject[] Crowd = new GameObject[CrowdSize];

    void Start()
    {
        WorldSizeX = spawn.position.x;
        WorldSizeY = spawn.position.y;
        WorldSizeZ = spawn.position.z;

        for(int i = 0; i <CrowdSize; i++)
        {
            Vector3 pos = new Vector3(WorldSizeX + Random.Range(-WorldSize, WorldSize), WorldSizeY + Random.Range(-WorldSize, WorldSize), WorldSizeZ + Random.Range(-WorldSize, WorldSize));
            Crowd[i] = (GameObject)Instantiate(Prefab, pos, Quaternion.identity);
        }
    }

    void Update()
    {
        if (Random.Range(0, 10000) < 50)
            goalPos = new Vector3(WorldSizeX + Random.Range(-WorldSize, WorldSize), WorldSizeY + Random.Range(-WorldSize, WorldSize), WorldSizeZ + Random.Range(-WorldSize, WorldSize));
        goal.transform.position = goalPos;
    }
}
