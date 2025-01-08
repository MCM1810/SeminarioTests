using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour
{
    
    private QuestionForm questionform;

    public Text preguntaTexto;

    public Text botonText1;
    public Text botonText2;
    public Text botonText3;

    public AnswerController Respuesta1;
    public AnswerController Respuesta2;
    public AnswerController Respuesta3;


    public void MostrarPreguntas(int pregunta, List<QuestionForm> preguntas)
    {
        questionform = preguntas[pregunta];

        preguntaTexto.text = questionform.pregunta;

        botonText1.text = questionform.alternativa1;
        Respuesta1.correcto = questionform.respuestaAlternativa1;

        botonText2.text = questionform.alternativa2;
        Respuesta2.correcto = questionform.respuestaAlternativa2;

        botonText3.text = questionform.alternativa3;
        Respuesta3.correcto = questionform.respuestaAlternativa3;


    }

}
