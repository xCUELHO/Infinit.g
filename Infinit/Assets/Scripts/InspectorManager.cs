using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InspectorManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public GameObject TextInput;
    private string input;

    public void enableTextInput(){
        TextInput.SetActive(true);
    }

    public void ReadStringInput(string s){
        input = s;
        Debug.Log(input);
        textDisplay.text = input.ToString();
        PlayerMoviment.nome = input.ToString();
    }
}