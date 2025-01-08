using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerController : MonoBehaviour
{
    public bool correcto;
    public Cronometro cronometro;
    public ComodinController comodincontroller;
    public GameObject UIQuestion;
    public GameObject Boton;

    public void Confirmar()
    {
        if (correcto)
        {
            Boton.GetComponent<Image>().color = Color.green;
            Invoke("ocultarComodin", 0.7f);
            comodincontroller.MoverPiezasPorComodin();
            
        }
        else
        {
            Boton.GetComponent<Image>().color = Color.red;
            Invoke("ocultarComodin", 0.7f);
        }
    }

    public void ocultarComodin()
    {
        cronometro.continuar();
        UIQuestion.SetActive(false);
        Boton.GetComponent<Image>().color = new Color(127, 77, 41);
    }
}
