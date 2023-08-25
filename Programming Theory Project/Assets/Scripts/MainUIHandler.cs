using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainUIHandler : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI ageText;

    private void Start()
    {
        nameText.text = "UserName: " + MainManager.Instance.GetUserName();
        ageText.text = "Age: " + MainManager.Instance.GetAge().ToString();
    }
}
