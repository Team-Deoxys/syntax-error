using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class QuestionGenerator : MonoBehaviour
{
    public string questionFile = "Questions.txt";
    public string dFile = "d.txt";

    


    private void Start()
    {
        GenerateQuestions();

    }

    private void GenerateQuestions()
    {
        List<string> questionsAndAnswers = new List<string>
        {
            "What is a fruit and also a colour?|Orange",
            "What is full of holes but still full of water?|Sponge",
            "What is always in front of you but can't be seen?|Future",
            "What goes up but never comes down?|Age",
            "What kind of room has no doors or windows?|Mushroom",
            "Poor people have it. Rich people need it. If you eat it you die. What is it?|Nothing",
            "What runs but never walks. Murmurs but never talks. Has a bed but never sleeps. And has a mouth but never eats?|River"
        };

        List<string> dques = new List<string>
        {
            "Name the person from Tamil Nadu who received his PhD at age 70.|rajagopal",
            "Name the founder of the first unicorn in India.|naveentiwari",
            "What is the premier event hosted by SDSLABS each year?|syntaxerror",
            "Which company became the latest one to join a Trillion Dollar Net Worth club?|nvidia",
            "Which country scored the highest team total in T20Is.|nepal",
            "Who has the highest individual score in international test matches?|brianlara",

        };
        int randomIndex = UnityEngine.Random.Range(0, dques.Count);
        string randomdqAnswer = dques[randomIndex];
        
        
        File.WriteAllLines(questionFile, questionsAndAnswers.ToArray());
        File.WriteAllText(dFile, randomdqAnswer);
    }
}
