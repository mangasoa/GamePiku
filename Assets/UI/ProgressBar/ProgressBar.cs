using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ProgressBar : MonoBehaviour
{
    Image bar;
    TextMeshProUGUI txt;

    private float val;

    public Color AlerteColor = Color.red;
    Color startColor;

    public float alerte = 25f;

    public float Val
    {
        get
        {
            return val;
        }
        set
        {
            val = value;
            val = Mathf.Clamp(val, 0, 100);
            UpdateValue();
        }
    }


    // Start is called before the first frame update
    void Awake()
    {
        bar = transform.Find("Bar").GetComponent<Image>();
        txt = bar.transform.Find("Text").GetComponent<TextMeshProUGUI>();
        startColor = bar.color;
        Val = 100;
        
    }


    void UpdateValue()
    {
        txt.text = val + "%";
        bar.fillAmount = val / 100;

        if(val<=alerte)
        {
            bar.color = AlerteColor;
        }
        else
        {
            bar.color = startColor;
        }
    }

    //Test ProgressBar if it works
    void Update()
    {
        if(Input.GetKey(KeyCode.KeypadMinus))
        {
            Val--;
        }
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            Val++;
        }
    }
}
