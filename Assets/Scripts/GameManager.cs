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

    //s  public GameObject player;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        // Instantiate(player, transform.position,Quaternion.identity);
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

    public void WinGame(bool winGame)
    {

    }
    public void LoseGame(bool loseGame)
    {

    }

}
