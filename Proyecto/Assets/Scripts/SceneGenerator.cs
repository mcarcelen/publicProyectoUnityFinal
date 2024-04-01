using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGenerator : MonoBehaviour
{
    public GameObject[] objects;
    public float minDistance;
    public Transform endPoint;
    public int initialObjects;
    public Transform jugador;
    public int lvlCounter;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i = 0; i < initialObjects; i++)
        {
            GenerateLevel();
        }
    }
    private void Update()
    {
        if (Vector2.Distance(jugador.position, endPoint.position) < minDistance)
        {
            GenerateLevel();
            lvlCounter++;
            endLevelGeneration();
        }
    }

    private void GenerateLevel()
    {
        int numRandom = Random.Range(0, objects.Length-1);
        GameObject level = Instantiate(objects[numRandom], endPoint.position, Quaternion.identity);
        endPoint = SearchEndPoint(level, "EndPoint");
    }

    private Transform SearchEndPoint(GameObject objects, string tag)
    {
        Transform point = null;

        foreach (Transform location in objects.transform)
        {
            if (location.CompareTag(tag))
            {
                point = location;
                break;
            }
        }
        return point;
    }

    private void endLevelGeneration()
    {
        if (lvlCounter == 5)
        {
            GameObject level = Instantiate(objects[objects.Length -1], endPoint.position, Quaternion.identity);
            endPoint = SearchEndPoint(level, "EndPoint");
        }
    }
}
