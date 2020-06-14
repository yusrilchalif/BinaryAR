using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jawaban : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.SetInt("Score: ", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jawaba(bool jawab){
        if(jawab){
            dapetScore.scoreAmount += 10;
            Debug.Log("Jawaban Benar");
        }else{
            Debug.Log("Jawaban Salah");
        }

        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex()+1).gameObject.SetActive(true);
    }
}
