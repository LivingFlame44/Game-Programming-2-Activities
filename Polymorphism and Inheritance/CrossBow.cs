using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossBow : Archer
{
    public override void Job()
    {
        base.Job();
        Debug.Log("2nd Job: Crossbow");
    }
}
