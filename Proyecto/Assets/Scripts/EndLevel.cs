using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
                SceneManager.LoadScene(1);
                ObjectGenerator.currentItemCounter = 0;
                ObjectGenerator.itemCounter = 0;
                ObjectGenerator.totalFruits += 5;
            }
        }
}
