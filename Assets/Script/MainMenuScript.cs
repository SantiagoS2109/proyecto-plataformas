using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class MainMenuScript : MonoBehaviour
 {
 
     // Use this for initialization
     void Start ()
     {
         
     }
     
     // Update is called once per frame
     void Update ()
     {
         
     }
 
     public void LoadSceneSelect()
     {
         SceneManager.LoadScene(1);
     }

     public void QuitGame()
     {
        print("Quit Game");
        Application.Quit();
     }
 }
