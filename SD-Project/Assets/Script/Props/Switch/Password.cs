using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    public string psw;

    void Start()
    {
        gameObject.GetComponent<InputField>().onEndEdit.AddListener(displayText);
    }

    public void displayText(string textInField)
    {
        psw = textInField;
    }


}
