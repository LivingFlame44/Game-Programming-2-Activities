using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wartortle : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Wartortle";
        dexNum = 0008;
        types = Types.Water;
        gender = Gender.Female;

        hp = 99;
        def = 49;
        atk = 79;
        spd = 19;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
