using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldToText : MonoBehaviour
{
    public Text InputTextBox;
    public Text OutputTextBox;
    public InputField inputField;

    public void CopyText()
    {
        inputField.text += InputTextBox.text;
    }
}
