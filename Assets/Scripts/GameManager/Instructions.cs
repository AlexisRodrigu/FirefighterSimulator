using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
 [SerializeField] private TimerController timerController;
    void Update()
    {
        Check();
    }
    void Check()
    {
        if(timerController.TimerStart == true)
            Destroy(this.gameObject);
    }
}
