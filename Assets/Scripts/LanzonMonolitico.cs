using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanzonMonolitico : MonoBehaviour
{
    public Text Titulo;
    public string Cultura = "Chavin";
    public string Ubicacion = "Ancash";
    public string Descripcion = "Esta escultura con forma de proyectil mide 4.54 metros esculpido con granitos irregulares. " +
        "Como las cabezas clavas, presentan rasgos humanos y animales. Se considera como la divinidad suprema de su cultura, llegando a la altura de Viracocha," +
        "el dios supremo de los Incas. No olvidar que forma parte de las esculturas mas antiguas del Peru ";

    public Text culturaText;
    public Text ubicacionText;
    public Text descripcionText;
    public Text tituloText;

    public Image FiguraPuzzle1;
    public Image FiguraPuzzle2;

    public void ReescribirInformacion()
    {
        culturaText.text = "Cultura: " + Cultura;
        ubicacionText.text = "Ubicacion: " + Ubicacion;
        descripcionText.text = Descripcion;
        tituloText.text = Titulo.text;
    }

    public void ReescribirFigura1(Sprite sprite)
    {
        FiguraPuzzle1.sprite = sprite;
    }

    public void ReescribirFigura2(Sprite sprite)
    {
        FiguraPuzzle2.sprite = sprite;
    }
}
