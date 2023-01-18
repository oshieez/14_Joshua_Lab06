using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyConverter : MonoBehaviour
{
    public Toggle USD;
    public Toggle JapaneseYen;
    public Toggle MalaysiaRM;
    public Toggle ThailandBhat;

    public Text Value;

    public string input;
    public double inputValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void readvalue(string s)
    {
        input = s;
        
        double.TryParse(input, out inputValue);
    }
    public void ConvertBtn()
    {
        if (USD.isOn)
        {
            inputValue *= 0.74f;
        }
        if (JapaneseYen.isOn)
        {
            inputValue *= 97.14f;
        }
        if (MalaysiaRM.isOn)
        {
            inputValue *= 0.31f;
        }
        if (ThailandBhat.isOn)
        {
            inputValue *= 17785.74;
        }

        Value.text = "" + inputValue;
    }
    public void clearBtn(InputField s)
    {
        s.text = "" + 0;
        Value.text = "" + s;
    }
}
