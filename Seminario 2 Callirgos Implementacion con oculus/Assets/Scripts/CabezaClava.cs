using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabezaClava : MonoBehaviour
{
    public Text Titulo;
    public string Cultura = "Chavin";
    public string Ubicacion = "Ancash";
    public string Descripcion = "Pertenecientes al templo de Chavin de Huantar, estas esculturas presentan ser mitad humano y mitad animal (como felino, serpiente y ave de rapaz). " +
        "Su funcion no es de todo clara: unos afirman se comportan como guardianes contra los malos espiritus, otros afirman que son los sacerdotes de la cultura, e incluso son considerados como" +
        "cabezas trofeos de sus enemigos. Solo existe uno en su ubicacion original";

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
