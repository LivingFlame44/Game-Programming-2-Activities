using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class SkillInfoSelection : MonoBehaviour
{
    public SkillManager skillManager;
    public Transform parentPos;
    public GameObject holoMemButtonPrefab;
    public HoloMemInfoView holoMemInfoView;
    public HoloMemManager holoMemManager;
    void Start()
    {
        foreach (HoloMem p in holoMemManager.holoMems)
        {
            GameObject buttonPrefab = Instantiate(holoMemButtonPrefab, parentPos);
            MemInfoBtn memInfoBtn = buttonPrefab.GetComponent<MemInfoBtn>();
            memInfoBtn.SetMemIcon(p);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => holoMemInfoView.DisplayMemInfo(p));
        }


    }
}
