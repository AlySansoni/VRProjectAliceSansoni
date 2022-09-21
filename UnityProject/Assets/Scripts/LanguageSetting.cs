using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LanguageSetting : MonoBehaviour
{
    public static string Language;
    public Button startButton;

    public void NewGameButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ItalianButton()
    {
        Language = "italian";
        Debug.Log(Language);
        startButton.interactable = true;
    }

    public void EnglishButton()
    {
        Language = "english";
        Debug.Log(Language);
        startButton.interactable = true;
    }
}
