using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HuacoRetrato : MonoBehaviour
{
    public Text Titulo;
    public string Cultura = "Mochica";
    public string Ubicacion = "Costa norte";
    public string Descripcion = "Tambien llamado cabeza retrato,1 huaco-retrato, vaso-retrato o botella retrato; " +
        "es una vasija de cerámica con una representación altamente individualizada y naturalista de un " +
        "rostro humano. son algunas de las pocas representaciones realistas de humanos que se " +
        "encuentran en la América precolombina. Su uso van desde vasijas portatiles hasta rituales funerarios";

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

