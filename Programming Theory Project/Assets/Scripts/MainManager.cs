using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }
    private UIHandler uIHandler;
    private Image nameFieldImage;
    private Image ageFieldImage;
    public string inputName;
    public int inputAge;
    public short readyToStart;   // When value is 2, Game can start

    // ENCAPSULATION
    public string InputName
    {
        get { return inputName; }
        set
        {
            if (value == "")
            {
                nameFieldImage.color = new Color32(255, 182, 182, 255);
            }
            else
            {
                nameFieldImage.color=Color.white;
                inputName = value;
                readyToStart++;
            }
        }
    }
    public int InputAge
    {
        get { return inputAge; }
        set
        {
            if(value < 0)
            {
                uIHandler.ageField.text = "";
                ageFieldImage.color = new Color32(255,182,182,255);
            }
            else
            {
                ageFieldImage.color = Color.white;
                inputAge = value;
                readyToStart++;
            }
        }
    }

    private void Awake()
    {
        uIHandler = GameObject.Find("Canvas").GetComponent<UIHandler>();
        nameFieldImage = uIHandler.nameField.GetComponent<Image>();
        ageFieldImage = uIHandler.ageField.GetComponent<Image>();
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public string GetUserName()
    {
        return inputName;
    }
    public int GetAge()
    {
        return inputAge;
    }
}
