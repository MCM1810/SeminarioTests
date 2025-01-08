using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionForm : MonoBehaviour
{
    public string pregunta;
    public string alternativa1;
    public bool respuestaAlternativa1;
    public string alternativa2;
    public bool respuestaAlternativa2;
    public string alternativa3;
    public bool respuestaAlternativa3;

    public QuestionForm(string pregunta, string alternativa1, 
        bool respuestaAlternativa1, string alternativa2, 
        bool respuestaAlternativa2, string alternativa3, bool respuestaAlternativa3)
    {
        this.pregunta = pregunta;
        this.alternativa1 = alternativa1;
        this.respuestaAlternativa1 = respuestaAlternativa1;
        this.alternativa2 = alternativa2;
        this.respuestaAlternativa2 = respuestaAlternativa2;
        this.alternativa3 = alternativa3;
        this.respuestaAlternativa3 = respuestaAlternativa3;
    }
}
