using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogWarning("GameManager is null");

            return _instance;
        }
    }
    [SerializeField] private TimerController timerController;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LifeFire lifeFireScript;

    #region  variables de condicion de victoria
    // [SerializeField] private Image image;
    [SerializeField] private GameObject winGO;
    [SerializeField] private GameObject loseGO;
    [SerializeField] private float timeForWin;
    #endregion
    //s  public GameObject player;
    private void Awake()
    {
        _instance = this;
    }
    private void Update()
    {
        VictoryCondition();
    }

    public void StarGame(bool startGame)
    {
        if (startGame == false)
        {
            playerController.SpeedPlayer = 0.0f;
            timerController.TimerStart = false;
        }
        else
        {
            timerController.TimerStart = true;
            playerController.SpeedPlayer = 5.0f;
        }
    }

    public void VictoryCondition()
    {
        if (timerController.Timer <= timeForWin && lifeFireScript.ExtinguishedFire == true)
        {
            winGO.SetActive(true);
            timerController.TimerStart = false;
            playerController.SpeedPlayer = 0.0f;
        }

        else if (timerController.Timer >= timeForWin)
        {
            loseGO.SetActive(true);
            playerController.SpeedPlayer = 0.0f;
        }

    }
}
