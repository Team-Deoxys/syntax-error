using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;
using System;

public class RiddleGenerator : MonoBehaviour
{
    public TextMeshProUGUI largeText;
    private string inputText;
    public int scene;
    private string Answer;
    private List<string> questionsAndAnswers = new List<string>();
    private string questionFile = "Questions.txt";

    private void Start()
    {
        LoadQuestions();
        LoadRandomRiddle();
    }

    private void LoadQuestions()
    {
        if (File.Exists(questionFile))
        {
            string[] lines = File.ReadAllLines(questionFile);

            foreach (string line in lines)
            {
                questionsAndAnswers.Add(line);
            }
        }
    }

    private void SaveQuestions()
    {
        File.WriteAllLines(questionFile, questionsAndAnswers.ToArray());
    }

    private void LoadRandomRiddle()
    {
        if (questionsAndAnswers.Count > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, questionsAndAnswers.Count);
            string randomQuestionAnswer = questionsAndAnswers[randomIndex];
            questionsAndAnswers.RemoveAt(randomIndex);
            SaveQuestions();

            string[] parts = randomQuestionAnswer.Split('|');
            if (parts.Length == 2)
            {
                string question = parts[0];
                Answer = parts[1];

                largeText.text = question;
            }
        }
        else
        {
            largeText.text = "No more questions available.";
        }
    }

    public void OnInput(string input)
    {
        inputText = input.Trim();
        Answer = Answer.Trim();

        if (string.Equals(inputText, Answer, StringComparison.OrdinalIgnoreCase))
        {
            largeText.text = "The answer is correct";
            SceneManager.LoadSceneAsync(scene,LoadSceneMode.Single);
        }
        else
        {
            largeText.text = "Try again!";
        }
    }
}
