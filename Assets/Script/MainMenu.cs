using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Menu(){
        Application.LoadLevel("MainMenu");
    }

    public void Play(){
        Application.LoadLevel("AR");
    }

    public void Panduan(){
        Application.LoadLevel("Panduan");
    }

    public void Profil(){
        Application.LoadLevel("Profil");
    }

    public void Materi(){
        Application.LoadLevel("Materi");
    }

    public void Soal(){
        Application.LoadLevel("Soal");
    }

    public void Quit(){
         Application.Quit();
         Debug.Log("quit");
    }
    public void backMenu(){
        Application.LoadLevel("MainMenu");
    }
    
    void backTo(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.LoadLevel("MainMenu");
        }
    }
}
