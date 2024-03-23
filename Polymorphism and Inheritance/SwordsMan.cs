using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordsMan : Adventurer
{
    public override void Job()
    {
        base.Job();
        Debug.Log("1st Job: Swordsman");
    }
}
