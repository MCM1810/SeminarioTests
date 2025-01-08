using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionList : MonoBehaviour
{
    /*    public QuestionForm(string pregunta, string alternativa1, 
          bool respuestaAlternativa1, string alternativa2, 
          bool respuestaAlternativa2, string alternativa3, bool respuestaAlternativa3))*/

    /*NO OLVIDAR AUMENTAR EL VALOR INT NUMPREGUNTA AL ANADIR NUEVA PREGUNTA*/
    
    public int numPregunta;

    public List<QuestionForm> preguntas;

    public QuestionForm pregunta1;
    public QuestionForm pregunta2;
    public QuestionForm pregunta3;

    private void Start()
    {
        pregunta1 = new QuestionForm(
          "Escoger respuesta para la pregunta1",
          "verdadero", true,
          "falso", false,
          "falso", false);

        pregunta2 = new QuestionForm(
          "Escoger respuesta para la pregunta2",
          "falso", true,
          "falso", false,
          "verdadero", true);

        pregunta3 = new QuestionForm(
          "Escoger respuesta para la pregunta3",
          "verdadero", false,
          "falso", true,
          "verdadero", false);

        this.preguntas.Add(pregunta1);
        this.preguntas.Add(pregunta2);
        this.preguntas.Add(pregunta3);

        numPregunta = 3;

    }

    public int getNumPreguntas()
    {
        return numPregunta;
    }
 
}


