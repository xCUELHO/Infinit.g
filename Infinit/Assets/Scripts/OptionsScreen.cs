using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScreen : MonoBehaviour
{
    public Toggle fullscreenTog, vsyncTog;

    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen;

        if(QualitySettings.vSyncCount == 0){
            vsyncTog.isOn = false;
        }else{
            vsyncTog.isOn = true;
        }
    }

    public void ApplyGraphics(){
        Screen.fullScreen = fullscreenTog.isOn;

        if(vsyncTog.isOn){
            QualitySettings.vSyncCount = 1;
        }else{
            QualitySettings.vSyncCount = 0;
        }
    }
}
