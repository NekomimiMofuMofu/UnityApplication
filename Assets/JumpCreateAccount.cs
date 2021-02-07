using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpCreateAccount : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Scenes/CreateAccountScene");
    }
}
