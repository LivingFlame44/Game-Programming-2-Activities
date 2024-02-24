using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Chikorita : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Chikorita";
        dexNum = 0152;
        types = Types.Grass;
        gender = Gender.Female;

        hp = 105;
        def = 34;
        atk = 48;
        spd = 25;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
