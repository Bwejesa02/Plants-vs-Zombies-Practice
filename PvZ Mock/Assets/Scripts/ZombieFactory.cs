using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ZombieFactory
{
    public static Zombie CreateZombie()
    {
        int zombieType = Random.Range(0, 3);
        switch (zombieType)
        {
            case 0: return GameObject.Instantiate(Resources.Load<Zombie>("SunflowerZombie"));
            case 1: return GameObject.Instantiate(Resources.Load<Zombie>("PeashooterZombie"));
            case 2: return GameObject.Instantiate(Resources.Load<Zombie>("WallnutZombie"));
            default: return null;
        }
    }
}
