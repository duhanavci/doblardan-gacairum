using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool oyun_durduruldu;
    public void durdurbutton()
    {
        oyun_durduruldu = !oyun_durduruldu;
        if (oyun_durduruldu == true)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

  
}
