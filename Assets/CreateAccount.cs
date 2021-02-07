using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateAccount : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Scenes/LoginScene");
    }
}