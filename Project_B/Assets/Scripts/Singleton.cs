using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour                         //1°³·Î ½Ì±ÛÅæ Å¬·¡½º À¯Áö
{    // Start is called before the first frame update
    public static Singleton Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int playerScore = 0;

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }
}
