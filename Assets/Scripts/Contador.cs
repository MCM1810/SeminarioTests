using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text NumContador;

    public GameObject ContadorUI;
    public GameObject Referencia;
    public GameObject Cronometro;
    public GameObject Pizarra;
    public GameObject Resultado;
    public GameObject Comodin;

    private int escaladetiempo = 1;
    private int escalatiemporapausar = 1;

    private float timeElapsed = 0;
    private int minutes, seconds, cents;

    private bool estapausado = false;

    private void Update()
    {
        if (!estapausado)
        {
            timeElapsed += Time.deltaTime * escaladetiempo;
            minutes = (int)(timeElapsed / 60f);
            seconds = (int)(timeElapsed - minutes * 60f);

            NumContador.text = seconds.ToString();

            if (seconds > 3f)
            {
                Reinicio();
                Pausa();
                
                ContadorUI.SetActive(false);
                Referencia.SetActive(true);
                Cronometro.SetActive(true);
                Comodin.SetActive(true);

                Cronometro.GetComponent<Cronometro>().continuar();

                //Resetear piezas
                for (int i = 0; i < 36; i++)
                {
                    /*Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().PasoPorAlli = false;
                    Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().IsInPosition = false;*/
                    Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().InicioJuego = true;
                    
                }

                //Resultado.GetComponent<UIGanar>().Correcto = 0;


            }
            
        }
    }

    private void Pausa()
    {
        if (!estapausado)
        {
            estapausado = true;
            escalatiemporapausar = escaladetiempo;
            escaladetiempo = 0;

        }
    }

    private void continuar()
    {
        if (estapausado)
        {
            estapausado = false;
            escaladetiempo = escalatiemporapausar;

        }
    }
    private void Reinicio()
    {
        estapausado = false;
        seconds = 0;
        minutes = 0;
        timeElapsed = 0;
        NumContador.text = seconds.ToString();

    }

    public void IniciarContador()
    {
        continuar();
    }
}
