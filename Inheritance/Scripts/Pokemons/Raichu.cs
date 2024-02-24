using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Raichu : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Raichu";
        dexNum = 0026;
        types = Types.Electric;
        gender = Gender.Male;

        hp = 79;
        def = 25;
        atk = 44;
        spd = 26;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
