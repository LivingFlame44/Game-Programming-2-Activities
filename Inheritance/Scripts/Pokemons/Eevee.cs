using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Eevee : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Eevee";
        dexNum = 0133;
        types = Types.Normal;
        gender = Gender.Female;

        hp = 76;
        def = 41;
        atk = 44;
        spd = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
