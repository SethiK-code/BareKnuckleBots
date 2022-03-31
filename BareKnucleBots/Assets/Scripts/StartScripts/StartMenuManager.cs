using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuManager : MonoBehaviour
{
    public GameObject[] UIPanels;

    public void Awake()
    {
        DisableAllPanels(); //DisableAllPanels
        UIPanels[0].SetActive(true);
    }

    public void OnPressPlayGame()
    {
        UIPanels[0].SetActive(false);
        UIPanels[1].SetActive(true);
    }
    public void BackToMenuPG()
    {
        UIPanels[1].SetActive(false);
        UIPanels[0].SetActive(true);
    }

    public void sDebug()
    {
        Debug.Log("I'm Working!");
    }

    public void DisableAllPanels()
    {
        foreach (GameObject panel in UIPanels)
        {
            panel.SetActive(false);
        }
    }



}
