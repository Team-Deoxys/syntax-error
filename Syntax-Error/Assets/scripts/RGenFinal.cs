using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RGenFinal : MonoBehaviour
{
    public TextMeshProUGUI largeText;
    private string inputText;
    private string qfile = "d.txt";
    private string qna;
    private string q;
    private string a;
    // Start is called before the first frame update
    void Start()
    {
        qna = File.ReadAllText(qfile);
        string[] parts = qna.Split('|');
        if (parts.Length == 2)
        {
            q = parts[0];
            a = parts[1];
            largeText.text = q;
        }
    }

    public void OnInput(string input)
    {
        inputText = input.Trim();
        a = a.Trim();

        if (string.Equals(inputText, a, StringComparison.OrdinalIgnoreCase))
        {
            largeText.text = "The answer is correct";
            SceneManager.LoadScene("Credits");
        }
        else
        {
            largeText.text = "Try again!";
        }
    }
}

