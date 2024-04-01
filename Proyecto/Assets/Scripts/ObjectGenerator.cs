using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject[] Objetos;
    public static int itemCounter;
    public static int currentItemCounter;
    public static  int totalFruits = 10;
    public TMP_Text txtFruitsCollected;
    public TMP_Text txtTotalFruits;

    void Start()
    {
        StartCoroutine(SpawnObject());
        txtTotalFruits.text = totalFruits.ToString();
    }
    void Update()
    {
        txtFruitsCollected.text = currentItemCounter.ToString();
    }
    IEnumerator SpawnObject()
    {
        while(itemCounter < totalFruits)
        {
            float spawnPointX = Random.Range(-2.28f,2f);
            float spawnPointY = Random.Range(0f,22f);
            int numObj = Random.Range(0, Objetos.Length);

            if (numObj != Objetos.Length-1)
            {
                itemCounter++;
                Vector2 spawnPosition = new Vector2(spawnPointX, spawnPointY);
                GameObject objeto = Instantiate(Objetos[numObj], spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            else{
                Vector2 spawnPosition = new Vector2(spawnPointX, spawnPointY);
                GameObject objeto = Instantiate(Objetos[numObj], spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(3f);
            }
        }
    }
}
