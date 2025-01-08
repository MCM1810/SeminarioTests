using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceScript : MonoBehaviour
{
    public Vector3 RightPosition;
    public bool IsInPosition = false;
    public bool PasoPorAlli = false;
    public bool ColocadoCorrectamente = false;
    public bool ColocadoIncorrectamente = false;
    public bool InicioJuego = false;

    public float x1;
    public float x2;
    public float y1;
    public float y2;

    public UIGanar UIGanar;
    public GameObject Resultado;



    public void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(x1, x2), Random.Range(y1, y2), -83.17f);
    }

    public void resetear()
    {
        transform.position = new Vector3(Random.Range(x1, x2), Random.Range(y1, y2), -83.17f);
    }

    
    

    // Update is called once per frame
    void Update()
    {
        if(InicioJuego == true)
        {
            //Si esta cerca al punto
            if (Vector3.Distance(transform.position, RightPosition) < 0.1f)
            {
                transform.position = RightPosition;
                IsInPosition = true; //para confirmar que esta en su posicion
                while (ColocadoCorrectamente == false) //aqui controla los numeros de actualizaciones
                {
                    UIGanar.Corregir(IsInPosition, PasoPorAlli);
                    PasoPorAlli = true; //se confirma que paso por alli
                    ColocadoCorrectamente = true;
                    ColocadoIncorrectamente = false;
                }

            }
            else
            {

                IsInPosition = false; //caso contrario se pone falso

                while (ColocadoIncorrectamente == false && PasoPorAlli)//aqui controla los numeros de actualizaciones
                {
                    UIGanar.Corregir(IsInPosition, PasoPorAlli);
                    ColocadoIncorrectamente = true;
                    ColocadoCorrectamente = false;

                }
            }

        }
    }
}
