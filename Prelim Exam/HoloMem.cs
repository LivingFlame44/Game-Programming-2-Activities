using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
[CreateAssetMenu(fileName = "HoloMem", menuName = "ScriptableObjects/HoloMem")]
public class HoloMem : ScriptableObject
{
    public new string name;
    public Sprite btnPic;
    public Sprite infoPic;
    public int atk;
    public int hp;
    public int spd;
    public SpecialSkill[] moves;

}
