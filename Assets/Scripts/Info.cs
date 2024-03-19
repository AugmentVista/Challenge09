using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Info : MonoBehaviour
{
    //bool active;
    public TMP_Text Speech;
    float timer;
    void Start()
    {
        timer = 0;
        Speech.text = "";
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0) timer = 0;

        if (timer == 0)
        {
            Speech.text = "";
        }
    }
    public void SetText(string text)
    {
        Speech.text = text;
        timer = 2;
    }
}