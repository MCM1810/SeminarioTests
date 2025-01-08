using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComodinController : MonoBehaviour
{
    private List<int> ListInt;
    private List<int> ListShuffle;

    private List<int> ListIntPreguntas;
    private List<int> ListShufflePreguntas;
    public int contadorPreguntas;

    public int indice = 0;
    private bool Parar = false;
    public GameObject Pizarra;
    public int ComodinAcumulador;
    public Cronometro cronometro;
    public Text ComodinTexto;
    public int ComodinAcumulador2;
    public int TiempoPorRecarga;
    public GameObject UIQuestion;

    public QuestionController questionConroller;
    private List<QuestionForm> Imagen1;
    private List<QuestionForm> Imagen2;
    private List<QuestionForm> Imagen3;

    public int TipoImagen;
    public bool cambioDeMinuto = false;

    

    private void Start()
    {
        Imagen1 = new List<QuestionForm>();
        Imagen2 = new List<QuestionForm>();
        Imagen3 = new List<QuestionForm>();
        /////crear preguntas/////

        QuestionForm pregunta1 = new QuestionForm(
         "¿En qué cultura enterraban a los fallecidos en “fardos funerarios”?",
         "Nazca", false,
         "Chavin", false,
         "Paracas", true);

        QuestionForm pregunta2 = new QuestionForm(
          "¿Qué significado tiene las líneas de nazca?",
          "Calendario astronómico", true,
          "Mensaje de dioses", false,
          "Cementerios sagrados", false);

        QuestionForm pregunta3 = new QuestionForm(
          "Cultura que destaca los “huacos retratos”",
          "Tiahuanaco", false,
          "Mochica", true,
          "Nazca", false);

        QuestionForm pregunta4 = new QuestionForm(
          "¿Cuál es considerado como la cultura más antigua del Perú?",
          "Paracas", false,
          "Chavín", true,
          "Mochica", false);

        QuestionForm pregunta5 = new QuestionForm(
          "¿Cuál es considerada como la última cultura preinca?",
          "Mochica", false,
          "Chimú", true,
          "Tiahuanaco", false);

        QuestionForm pregunta6 = new QuestionForm(
          "Actividad que sobresalían la cultura chimú",
          "Metalurgia", true,
          "Escultura", false,
          "Agricultura", false);

        QuestionForm pregunta7 = new QuestionForm(
          "¿Cómo se llaman los geoglifos o " +
          "figuras zoomorfas o antropomorfas que se ubica " +
          "en el departamento de Ica?",
          "Líneas Nazca", true,
          "Geoglifos de la estepa", false,
          "Jeroglifos egipcios", false);

        QuestionForm pregunta8 = new QuestionForm(
          "Nombre de actividad medica practicada en la " +
          "cultura Paracas con el cráneo de paciente",
          "Trepanaciones craneanas", true,
          "Craneotomía", false,
          "Estiramiento del cráneo", false);

        QuestionForm pregunta9 = new QuestionForm(
          "Seleccione el orden cronológico de las culturas",
          "Nazca-Paracas-Chavin", false,
          "Parasca-Nazca-Chavin", false,
          "Chavin-Paracas-Nazca", true);

        this.Imagen1.Add(pregunta1);
        this.Imagen1.Add(pregunta2);
        this.Imagen1.Add(pregunta7);
        this.Imagen2.Add(pregunta3);
        this.Imagen2.Add(pregunta4);
        this.Imagen2.Add(pregunta8);
        this.Imagen3.Add(pregunta5);
        this.Imagen3.Add(pregunta6);
        this.Imagen3.Add(pregunta9);


        ///Barajiar las piezas y las preguntas//

        Barajiar();
        BarajiarPreguntas();
        ComodinAcumulador = int.Parse(ComodinTexto.text);
        ComodinAcumulador2 = 0;
        contadorPreguntas=0;

}
    private void Update()
    {
        ComodinTexto.text = "" + ComodinAcumulador;

        //parte en donde aumenta el comodin por un minuto que pase
      
        if (cronometro.seconds == 0 && cambioDeMinuto == true)
        {
            ComodinAcumulador++;
            ComodinAcumulador2 = 0;
            cambioDeMinuto = false;
        }

        if (cronometro.seconds == 59)
        {
            cambioDeMinuto = true;
        }

        if (cronometro.seconds == ComodinAcumulador2 + TiempoPorRecarga)
        {
            ComodinAcumulador++;
            ComodinAcumulador2 = ComodinAcumulador2 + TiempoPorRecarga;

            
        }
        
    }

    public void setImagen(int tipo)
    {
        this.TipoImagen = tipo;
    }

    public void BarajiarPreguntas()
    {
        ListIntPreguntas = OrderedInts(Imagen1.Count);
        ListIntPreguntas = OrderedInts(Imagen2.Count);
        ListIntPreguntas = OrderedInts(Imagen3.Count);
        ListShufflePreguntas = GenerateRandomLoop(ListIntPreguntas);
    }

    public void Barajiar()
    {
            ListInt = OrderedInts(36);
            ListShuffle = GenerateRandomLoop(ListInt);
    }

    public void AbrirComodin()
    {
        if (ComodinAcumulador > 0)
        {
            cronometro.Pausa();
            UIQuestion.SetActive(true);
            if (TipoImagen == 1)
            {
                questionConroller.MostrarPreguntas(ListShufflePreguntas[contadorPreguntas], Imagen1);
            }
            else
            {
                if (TipoImagen == 2)
                {
                    questionConroller.MostrarPreguntas(ListShufflePreguntas[contadorPreguntas], Imagen2);
                }
                else
                {
                    questionConroller.MostrarPreguntas(ListShufflePreguntas[contadorPreguntas], Imagen3);
                }
            }

            contadorPreguntas++;

            if (contadorPreguntas == Imagen1.Count)
            {
                contadorPreguntas = 0;
            }

        }

        ComodinAcumulador--;
        if (ComodinAcumulador < 0)
        {
            ComodinAcumulador = 0;
        }

    }
   
    public void MoverPiezasPorComodin()
    {

        for (int i = 0; i < 2; i++)
        {
            while (!Parar && indice != 35)
            {
                if (Pizarra.transform.Find("Pieza1 (" + ListShuffle[indice] + ")").GetComponent<PieceScript>().IsInPosition == false)
                {
                    Pizarra.transform.Find("Pieza1 (" + ListShuffle[indice] + ")").GetComponent<PieceScript>().transform.position = Pizarra.transform.Find("Pieza1 (" + ListShuffle[indice] + ")").GetComponent<PieceScript>().RightPosition;
                    indice++;
                    Parar = true;
                }
                else
                {
                    indice++;
                }
            }
            Parar = false;
        }



        
    }

    public List<int> OrderedInts(int size)
    {
        var numbers = new List<int>();

        for (int i = 0; i < size; i++)
        {
            numbers.Add(i);
        }

        return numbers;
    }

    public List<int> GenerateRandomLoop(List<int> listToShuffle)
    {
        for (int i = listToShuffle.Count - 1; i > 0; i--)
        {
            var k = Random.Range(0, i+1);
            var value = listToShuffle[k];
            listToShuffle[k] = listToShuffle[i];
            listToShuffle[i] = value;
        }
        return listToShuffle;
    }


}


