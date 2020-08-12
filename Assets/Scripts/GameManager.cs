using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // [SerializeField] private bool startGame;
    private void Awake()
    {
        _instance = this;

    }
    public void StarGame(bool startGame)
    {
        if (startGame == false)
            timerController.TimerStart = false;
        else
            timerController.TimerStart = true;
    }

}
