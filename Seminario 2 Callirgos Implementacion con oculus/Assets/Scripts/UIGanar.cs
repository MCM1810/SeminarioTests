using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGanar : MonoBehaviour
{
   
    public int Correcto = 0;
    public GameObject Resultado;
    public GameObject Pizarra;
    public ComodinController comodin;
    public int NumPiezas;
    public Text Tiempo;
    public Cronometro cronometro;
    public Text ComodinTexto;


    public void Corregir(bool afirmacion, bool PasoPorAlli)
    {
        if (afirmacion)
        {
            Correcto++;

            if(Correcto == 36)
            {
                Ganar();
            }
        }
        else if (PasoPorAlli == true)
        {
            Correcto--;
            if(Correcto < 0)
            {
                Correcto = 0;
            }

        }
    }

    public void Ganar()
    {
        for (int i = 0; i < 36; i++)
        {
            Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().InicioJuego = false;
        }
        Resultado.SetActive(true);

        //Correcto = 0;

        cronometro.Pausa();
        Resultado.transform.Find("Resultadotiempo").GetComponent<Text>().text = "Tu tiempo: "+ Tiempo.text;
        cronometro.Reinicio();

        

    }

    public void ResetearPizarra()
    {
        for (int i = 0; i < 36; i++)
        {
            Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().resetear();
            Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().ColocadoCorrectamente = false;
            Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().ColocadoIncorrectamente = false;
            Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().PasoPorAlli = false;
            Pizarra.transform.Find("Pieza1 (" + i + ")").GetComponent<PieceScript>().IsInPosition = false;
        }
            
        Correcto = 0;
        comodin.Barajiar();
        comodin.indice = 0;
        ComodinTexto.text = "0";
        comodin.ComodinAcumulador2 = 0;
        comodin.ComodinAcumulador = 0;
        comodin.contadorPreguntas = 0;


    }

    
}
