using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Healer healer;
    public Barbarian barbarian;
    public Gladiator gladiator;
    public SwordsMan swordsman;
    public Archer archer;
    public Adventurer adventurer;
    public CrossBow crossbow;   
    public Sniper sniper;
    // Start is called before the first frame update
    public GameObject healerBtn;
    public GameObject barbarianBtn;
    public GameObject swordsmanBtn;
    public GameObject gladiatorBtn;
    public GameObject adventurerBtn;
    public GameObject archerBtn;
    public GameObject sniperBtn;
    public GameObject crossbowBtn;
 

    void Start()
    {
        healer.Job();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
