using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] SpriteRenderer pinImageRenderer;
    [SerializeField] TextMeshPro pinTextRenderer;
    private PinSO pinInfo;

    public void Setup(PinSO pin)
    {
        pinInfo = pin;
        pinImageRenderer.sprite = pin.pinImage;
        pinTextRenderer.text = pin.pinText; 
    }
}
