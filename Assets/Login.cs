using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    void Start()
    {
        string LoginName = "admin";
        string PassWord = "aaaa";

        Text InputNameText = GameObject.Find("NameInputField/Text").GetComponent<Text>();
        Text InputPassText = GameObject.Find("PassInputField/Text").GetComponent<Text>();

        string InputName = InputNameText.ToString();
        string InputPass = InputPassText.ToString();
        
        bool NameAuth = LoginName == InputName;
        bool PassAuth = PassWord == InputPass;
        
        Debug.Log("LoginName is " + LoginName);
        Debug.Log("InputName is " + InputName);
        Debug.Log("InputNameText is " + InputNameText);
        Debug.Log("InputPassText is " + InputPassText);
        Debug.Log("PassWord is " + PassWord);
        Debug.Log("InputPass is " + InputPass);
        
        if (NameAuth && PassAuth)
        {
            SceneManager.LoadScene("Scenes/MenuScene");
        }
    }
}
