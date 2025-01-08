using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text NumCronometro;
    private float timeElapsed = 0;
    public int minutes,seconds, cents;

    private int escaladetiempo = 1;
    private int escalatiemporapausar = 1;

    private bool estapausado = false;

    private void Update()
    {
        if (!estapausado)
        {
            timeElapsed += Time.deltaTime;
            minutes = (int)(timeElapsed / 60f);
            seconds = (int)(timeElapsed - minutes * 60f);
            cents = (int)((timeElapsed - (int)timeElapsed) * 100f);

            NumCronometro.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
        }
            

    }

    public void Pausa()
    {
        if (!estapausado)
        {
            estapausado = true;


        }
    }

    public void continuar()
    {
        if (estapausado)
        {
            estapausado = false;


        }
    }
    public void Reinicio()
    {
        
        seconds = 0;
        minutes = 0;
        cents = 0;
        timeElapsed = 0;
        NumCronometro.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

    }

}
