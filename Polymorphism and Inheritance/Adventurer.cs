using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurer : MonoBehaviour
{
    public string name;
    public int attak;

    public virtual void Job()
    {
        Debug.Log("Base: Adventure");
    }
}
