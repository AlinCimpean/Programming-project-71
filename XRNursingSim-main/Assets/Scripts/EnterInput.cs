using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterInput : MonoBehaviour
{
    public Text LoginIDStorage;
    public Text LoginIDCapture;
    public InputField inputField;
    public Text DisplayUser;
    public GameObject LoginScreen;
    public GameObject MenuScreen;
    private string lengthCheck;
    //public GameObject PromptMessage;

    public void SubmitLogin()
    {
        lengthCheck = inputField.text;
        if (lengthCheck.Length >= 6 && lengthCheck.Length <= 10){ // If ID is valid
            LoginIDStorage.text = inputField.text; // store ID
            DisplayUser.text = inputField.text;
            LoginScreen.SetActive(false); // Update Screen
            MenuScreen.SetActive(true);
        }
        else
        {
            //PromptMessage.SetActive(true); // Show prompt text
        }
        

    }
}
