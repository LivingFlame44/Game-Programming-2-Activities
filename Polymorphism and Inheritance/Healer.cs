using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Adventurer
{
    public override void Job()
    {
        base.Job();
        Debug.Log("Healer Attacks");
    }
}
