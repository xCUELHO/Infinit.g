using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject Settings;
    public GameObject Menu;

    void Start(){
        Settings.SetActive(false);
    }

    public void EnableSettings(){
        Settings.SetActive(true);
        Menu.SetActive(false);
    }

    public void DisableSettings(){
        Menu.SetActive(true);
        Settings.SetActive(false);
    }
    public void MenuJogar(){
       SceneManager.LoadScene(1);
    }
}
