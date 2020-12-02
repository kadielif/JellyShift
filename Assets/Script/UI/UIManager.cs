using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject endPanel;
    public GameObject startPanel;

    public GameObject endfail;
    public GameObject endsucces;

    public bool isStart = false;

    #region Singleton
    public static UIManager instance = null;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    #endregion

    private void Start()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(false);
        startPanel.SetActive(true);
    }
    public void StartGame()
    {
        gamePanel.SetActive(true);
        endPanel.SetActive(false);
        startPanel.SetActive(false);
        GameController.instance.StartGame();
    }

    public void EndGame(bool isSuccess)
    {
        endPanel.SetActive(true);
        isStart = false;
        if (isSuccess)
        {
            endsucces.SetActive(true);
        }
        else
        {
            endfail.SetActive(true);
        }

    }

}

