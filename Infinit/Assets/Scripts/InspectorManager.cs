using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InspectorManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;

    // Update is called once per frame
    void Update()
    {
        textDisplay.text = PlayerMoviment.nome;
    }
}
