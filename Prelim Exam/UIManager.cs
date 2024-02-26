using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    
    public GameObject mainMenuPanel;
    public GameObject teamMenuPanel;
    public GameObject teamCreatePanel;
    public GameObject memberInfoPanel;
    public GameObject skillInfoPanel;
    public GameObject welcomeMenuPanel;
    public GameObject createTeamMenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {

    }
    public void OpenMainMenu() 
    {
        mainMenuPanel.SetActive(true);
        welcomeMenuPanel.SetActive(false);
    }

    public void OpenTeamMenu()
    {
        teamMenuPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }
    public void OpenMemberInfo() 
    {
        memberInfoPanel.SetActive(true);
        skillInfoPanel.SetActive(false);
        teamCreatePanel.SetActive(false);
    }

    public void OpenSkillInfo() 
    { 
        skillInfoPanel.SetActive(true);
        teamCreatePanel.SetActive(false);
        memberInfoPanel.SetActive(false);
    }

    public void OpenCreateTeamPanel()
    {
        teamCreatePanel.SetActive(true);
        skillInfoPanel.SetActive(false);
        memberInfoPanel.SetActive(false);
    }
}
