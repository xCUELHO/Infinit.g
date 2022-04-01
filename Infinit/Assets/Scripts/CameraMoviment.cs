using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoviment : MonoBehaviour
{
    private Vector3 Origin;
    private Vector3 Difference;
    private Vector3 ResetCamera;

    private bool drag = false;

    private void Start(){
        ResetCamera = Camera.main.transform.position;
    }

    private void LateUpdate() {
        if (Input.GetMouseButton(1)){
            Difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if (drag == false){
                drag = true;
                Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }else{
            drag = false;
        }

        if (drag){
            Camera.main.transform.position = Origin - Difference;
        }

        /*if(Input.GetMouseButton(1)){
            Camera.main.transform.position = ResetCamera;
        }*/
    }

}
