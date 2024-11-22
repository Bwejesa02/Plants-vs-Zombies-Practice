using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    public int maxZombies = 100;
    public int sun = 0;
    public int insanity = 0;
    public GameObject player;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddSun(int amount = 10)
    {
        sun += amount;
        Debug.Log("Sun: " + sun);
    }

    public void IncreaseInsanity(int amount = 1)
    {
        insanity += amount;
        Debug.Log("Insanity: " + insanity + "%");
    }

    public void TacticalNuke()
    {
        foreach (var zombie in GameObject.FindGameObjectsWithTag("Zombie"))
        {
            Destroy(zombie);
        }
        Debug.Log("Nuke deployed");
    }

    public void Flamethrower()
    {
        foreach (var zombie in GameObject.FindGameObjectsWithTag("Zombie"))
        {
            if (Mathf.Abs((zombie.transform.position.y) - (player.transform.position.y)) < 1)
            {
                Destroy(zombie);
            }
        }
        Debug.Log("Flamethrower deployed");
    }

    public void Dynamite()
    {
        //dynamite
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
}

