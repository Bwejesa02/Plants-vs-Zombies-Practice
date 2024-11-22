using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public TextMeshProUGUI nukeButtonText;
    public TextMeshProUGUI flameButtonText;
    public TextMeshProUGUI dynamiteButtonText;

    private void Start()
    {
        UpdateNukeButtonText();
        UpdateFlameButtonText();
        UpdateDynamiteButtonText();
    }

    public void OnNukeButtonPressed()
    {
        FindObjectOfType<Shop>().BuyTacticalNuke();
        UpdateNukeButtonText();
    }

    private void UpdateNukeButtonText()
    {
        nukeButtonText.text = $"You have {Manager.Instance.sun})";
    }

    public void OnFlameButtonPressed()
    {
        FindObjectOfType<Shop>().BuyFlamethrower();
        UpdateFlameButtonText();
    }

    private void UpdateFlameButtonText()
    {
        flameButtonText.text = $"You have {Manager.Instance.sun})";
    }

    public void OnDynamiteButtonPressed()
    {
        FindObjectOfType<Shop>().BuyDynamite();
        UpdateDynamiteButtonText();
    }

    private void UpdateDynamiteButtonText()
    {
        dynamiteButtonText.text = $"You have {Manager.Instance.sun})";
    }
}
