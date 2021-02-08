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

        var InputNameText = GameObject.Find("NameInputField").GetComponent<InputField>().text;
        var InputPassText = GameObject.Find("PassInputField").GetComponent<InputField>().text;
        
        bool NameAuth = LoginName == InputNameText;
        bool PassAuth = PassWord == InputPassText;
        
        Debug.Log("LoginName is " + LoginName);
        Debug.Log("InputNameText is " + InputNameText);
        Debug.Log("InputPassText is " + InputPassText);
        Debug.Log("PassWord is " + PassWord);
        
        if (NameAuth && PassAuth)
        {
            SceneManager.LoadScene("Scenes/MenuScene");
        }
    }
}
