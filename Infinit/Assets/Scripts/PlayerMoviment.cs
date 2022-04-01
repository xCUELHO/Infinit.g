using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public GameObject outline;
    public bool selected = false;
    
    void Update()
    {
        //Movimento e Outline
        if(selected){
            outline.SetActive(true);
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
