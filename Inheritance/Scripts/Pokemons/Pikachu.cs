using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Pikachu : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Pikachu";
        dexNum = 0025;
        types = Types.Electric;
        gender = Gender.Male;

        hp = 110;
        def = 31;
        atk = 63;
        spd = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
