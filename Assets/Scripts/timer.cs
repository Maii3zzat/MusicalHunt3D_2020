using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerLabel;

    private float time;

    void Update()
    {
        time += Time.deltaTime;

        var minutes = time / 120; 
        var seconds = time % 60;
        var fraction = (time * 100) % 100;

        timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);

    }
}