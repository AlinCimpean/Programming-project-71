using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackspaceInput : MonoBehaviour
{
    public Text TextBox;
    public InputField inputField;
    private string AquiredText;
    private string UpdatedText;
  
    public void BackspaceText()
    {
        AquiredText = inputField.text;
        UpdatedText = AquiredText.Remove(AquiredText.Length - 1, 1);
        inputField.text = UpdatedText;
    }
}
