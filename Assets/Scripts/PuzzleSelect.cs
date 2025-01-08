using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSelect : MonoBehaviour
{
    public GameObject SelectorUI;
    public GameObject Referencia;
    public GameObject Play;

  
    
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i<36; i++)
        {
            GameObject.Find("Pieza1 (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        Referencia.transform.Find("Imagen").GetComponent<Image>().sprite = Photo.sprite;
        Play.transform.Find("Figura").GetComponent<Image>().sprite = Photo.sprite;
        
        
    }

    public void SetPuzzlesText(Text text)
    {
        Play.transform.Find("Titulo").GetComponent<Text>().text = text.text;
    }

   
}
