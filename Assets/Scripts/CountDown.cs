using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{

    public GameObject clock;
    public float countdown = 60f;
    public TextMeshProUGUI text;
        
   

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        text.text = countdown.ToString("0");
        if(countdown < 0)
        {
            
            clock.SetActive(true);
            Time.timeScale = 0.0f;

        }
    }
}
