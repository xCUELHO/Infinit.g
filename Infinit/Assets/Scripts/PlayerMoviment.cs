using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public GameObject outline;
    public GameObject inspector;
    public bool selected = false;
    
    [SerializeField]
    public static string nome = "Coloque seu nome aqui!";
    public static string[] atributos = {"Vida", "Velocidade", "Depressão"};
    public static float[] valores = {15, 75, 100};
    
    void Update()
    {
        //Movimento e Outline
        if(selected){
            outline.SetActive(true);
            inspector.SetActive(true);
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                transform.Translate(0, 1f, 0);
            }else if(Input.GetKeyDown(KeyCode.DownArrow)){
                transform.Translate(0, -1f, 0);
            }else if(Input.GetKeyDown(KeyCode.LeftArrow)){
                transform.Translate(-1f, 0, 0);
            }else if(Input.GetKeyDown(KeyCode.RightArrow)){
                transform.Translate(1f, 0, 0);
            }
        }else{
            outline.SetActive(false);
            inspector.SetActive(false);
        }
    }

    //Seleciona o personagem quando clica
    private void OnMouseDown() {
        if(!selected){
            selected = true;
        }else{
            selected = false;
        }
    }
}
