using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // INHERITANCE
    protected TextMeshProUGUI textArea;

    private void Awake()
    {
        textArea = GameObject.Find("Canvas").GetComponentInChildren<TextMeshProUGUI>();
    }
    private void OnMouseDown()
    {
        TextInc();
    }
    // POLYMORPHISM
    protected virtual void TextInc() { }

    // ABSTRACTION
    protected void ResetColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        textArea.text = "";
    }
    protected IEnumerator ResetRoutine()
    {
        yield return new WaitForSeconds(1);
        ResetColor();
    }
}
