using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirtle : Pokemon
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Squirle";
        dexNum = 0007;
        types = Types.Water;
        gender = Gender.Male;

        hp = 80;
        def = 31;
        atk = 49;
        spd = 18;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
