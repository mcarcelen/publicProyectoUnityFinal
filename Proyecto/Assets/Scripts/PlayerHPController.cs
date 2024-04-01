using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHPController : MonoBehaviour
{
    public int currentHP, maxHP;
    public static PlayerHPController instance;
    // Start is called before the first frame update
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage()
    {
        currentHP--;

        if(currentHP <= 0)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(0);
            ObjectGenerator.currentItemCounter = 0;
            ObjectGenerator.itemCounter = 0;
        }
    }
}
