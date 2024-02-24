using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Blastoise : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Blastoise";
        dexNum = 0009;
        types = Types.Water;
        gender = Gender.Male;

        hp = 100;
        def = 21;
        atk = 43;
        spd = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
