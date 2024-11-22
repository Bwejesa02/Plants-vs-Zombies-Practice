using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public void BuyTacticalNuke()
    {
        if (Manager.Instance.sun >= 300)
        {
            Manager.Instance.sun -= 300;
            Manager.Instance.TacticalNuke();
        }
        else
        {
            Debug.Log("Not enough moners");
        }
    }

    public void BuyFlamethrower()
    {
        if (Manager.Instance.sun >= 100) 
        {
            Manager.Instance.sun -= 100;
            Manager.Instance.Flamethrower();
        }
        else
        {
            Debug.Log("Not enough moners");
        }
    }

    public void BuyDynamite()
    {
        if (Manager.Instance.sun >= 50) 
        {
            Manager.Instance.sun -= 50;
            Manager.Instance.Dynamite();
        }
        else
        {
            Debug.Log("Not enough moners");
        }
    }
}


