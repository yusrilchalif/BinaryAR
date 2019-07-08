using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backMenu(){
        Application.LoadLevel("MainMenu");
    }
}
