using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);
            ObjectGenerator.currentItemCounter++;
        }
        else if (collision.CompareTag("Platform") || collision.gameObject.CompareTag("Remover"))
        {
            ObjectGenerator.itemCounter--;
            Destroy(gameObject);
        }
    }
}
