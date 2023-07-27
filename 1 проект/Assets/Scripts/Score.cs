using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    float score = 0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        score += Time.deltaTime;
        text.text = score.ToString("F0");
    }

}
