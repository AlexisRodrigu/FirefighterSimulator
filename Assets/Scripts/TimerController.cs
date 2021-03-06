﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimerController : MonoBehaviour
{

    [SerializeField]private TextMeshProUGUI timeCounterTxt;
    [SerializeField]private char character = ':';


    [SerializeField] private bool timerStart; //time going
    private float timer;
    private void Update()
    {
        if(timerStart)
        {
            timer += Time.deltaTime;
            UpdateText();
        }
    }
    private void UpdateText()
    {
        float seconds = (timer % 59);
        float minutes = ((int)(timer/59)%59);
        timeCounterTxt.text = minutes.ToString("00")+character+seconds.ToString("00");
    }
    
    public void StartTimer()
    {
        StartTimer(0);
    }
    public void StartTimer(float seconds)
    {
        timerStart = true;
        timer = seconds;
        UpdateText();
    }
}
