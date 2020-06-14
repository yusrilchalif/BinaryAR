using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Soal()
    {
        Application.LoadLevel("PilihanSoal");
    }

    public void Pilgan(){
        Application.LoadLevel("Soal");
    }

    
    public void Uraian(){
        Application.LoadLevel("SoalUraian");
    }

    public void MainMenu(){
        Application.LoadLevel("MainMenu");
    }
}
