using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollDice : MonoBehaviour
{
    public Text textDisplay;

    public void roll20(){
        int valor = Random.Range(1, 20);
        textDisplay.text = valor.ToString();
    }
}
