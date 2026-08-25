using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pin", menuName = "Pin")]
public class PinSO : ScriptableObject
{
    public Sprite pinImage;
    public string pinText;
    public PinEffect effectType;
    public float effectValue1;
    public float effectValue2;
    public int pinPrice; 
    public bool isUnique;
    public int unlockLevel;
}

public enum PinEffect
{
    Bartender,
    DJ,
    Waitress1,
    Waitress2,
    Waitress3,
    Guard,
    Salchipapa,
    Nachos,
    Hamburguesa,
    Arepa,
    HotDog,
    AdrenalynShot,
    Mojito,
    CubaLibre,
    BlueDemon,
    DragonShot,
    Martini,
    TequilaShot,
    SwitchSong
}
