using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    public override void Job()
    {
        base.Job();
        Debug.Log("2nd Job: Sniper");
    }
}
