using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        Application.LoadLevel("GamePlay");
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

    public void Quit(){
         Application.Quit();
         Debug.Log("quit");
    }
}
