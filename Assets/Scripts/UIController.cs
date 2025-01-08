using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject CentroUI;
    public GameObject AdelanteUI;
    public GameObject AtrasUI;

    public GameObject RutaOpcionalUI;


    public void HaciaAdelante()
    {
        AdelanteUI.SetActive(true);
        CentroUI.SetActive(false);
    }

    public void HaciaAtras()
    {
        CentroUI.SetActive(false);
        AtrasUI.SetActive(true);
    }

    public void HaciaOpcional()
    {
        RutaOpcionalUI.SetActive(true);
        CentroUI.SetActive(false);
    }

}
