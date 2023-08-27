using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public TMP_InputField nameField;
    public TMP_InputField ageField;

    public void StartGame()
    {
        MainManager.Instance.InputName = nameField.text;
        MainManager.Instance.InputAge = Convert.ToInt32(ageField.text);

        if (MainManager.Instance.readyToStart == 2)
        {
            SceneManager.LoadScene(1);
        }

        MainManager.Instance.readyToStart = 0;
    }
}
