using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{

    // Start is called before the first frame update
    void Start()
    {
        name = "Charmander";       
        dexNum = 0004;
        types = Types.Fire;
        gender = Gender.Male;

        hp = 165;
        def = 45;
        atk = 63;
        spd = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
