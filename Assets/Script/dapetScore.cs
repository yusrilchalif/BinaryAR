using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dapetScore : MonoBehaviour
{
    public static int scoreAmount;
    private Text skor;

    // Start is called before the first frame update
    void Start()
    {
        skor = GetComponent<Text>();
        scoreAmount = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        skor.text = "Score: " + scoreAmount;
    }
}
