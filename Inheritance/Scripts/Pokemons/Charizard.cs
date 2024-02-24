using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.Analytics;

public class Charizard : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Charizard";
        dexNum = 0006;
        types = Types.Fire;
        gender = Gender.Male;

        hp = 128;
        def = 29;
        atk = 49;
        spd = 24;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
