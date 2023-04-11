using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    public Image health_Bar;
    public GameObject panel;

    public bool is_dead = false;

    float i = 0;

    float health = 100.0f;
    float currentHealth = 100.0f;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sphere")
        {


            currentHealth -= 33.3f;
            health_Bar.fillAmount = currentHealth / health;
                

        i++;

            if (i == 3)
            {
                Destroy(gameObject);
                is_dead = true;
                panel.SetActive(true);
                Time.timeScale = 0.0f;
            }

        }

    }
    
}
        

