using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public Skill[] skills;

    private string folderPath1 = "Skill/Heal";
    private string folderPath2= "Damage";
    private string folderPath3 = "Shield"; // Folder name inside the Assets/Resources folder

    void Awake()
    {
        skills = Resources.LoadAll<Skill>(folderPath1);
        skills = Resources.LoadAll<Skill>(folderPath2);
        skills = Resources.LoadAll<Skill>(folderPath3);
    }
}