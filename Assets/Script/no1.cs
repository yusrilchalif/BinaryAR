using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class no1 : MonoBehaviour
{
    [SerializeField]
   Text jawaban;
   string codeTextValue = "";

    void Update()
    {
        jawaban.text = codeTextValue;

        if (codeTextValue == "9"){
            dapetScore.scoreAmount += 10;
            gameObject.SetActive(false);
            transform.parent.GetChild(gameObject.transform.GetSiblingIndex()+1).gameObject.SetActive(true);
        }

        if (codeTextValue.Length >= 8)
            codeTextValue = "";

    }

    public void AddDigit(string digit){
        codeTextValue += digit;
    }
}
