using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class LevelMove_Ref : MonoBehaviour
{
    public int sceneBuildIndex;
 
 
    private void OnTriggerEnter2D(Collider2D other) {
        print("Trigger Entered");
        

            // Player entered, so move level
        print("Switching Scene to " + sceneBuildIndex);
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        
    }
}