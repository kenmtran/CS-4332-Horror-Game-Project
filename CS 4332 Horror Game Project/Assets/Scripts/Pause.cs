using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseDisplay;
    public GameObject pauseText;
    public GameObject button;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            pauseDisplay.SetActive (false);
            pauseText.SetActive (false);
            startPause();
           
        }
        else if (Input.GetKeyDown("r")) {
            pauseDisplay.SetActive (false);
            pauseText.SetActive (false);
            button.SetActive (false);
            startRestart();
            
        }
    }

    void startPause() {
        if (isPaused == true){
            Time.timeScale = 1;
            isPaused = false;
            
        }
        else {
            Time.timeScale = 0;
            pauseDisplay.SetActive (true);
            pauseText.GetComponent<Text> ().text = "[PAUSED]";
            pauseText.SetActive (true);
            isPaused = true;
        }
    }

    void startRestart() {
        if (isPaused == true){
            Time.timeScale = 1;
            isPaused = false;
            
        }
        else {
            Time.timeScale = 0;
            pauseDisplay.SetActive (true);
            pauseText.GetComponent<Text> ().text = "PRESS THE BUTTON TO RESTART. PRESS R TO CANCEL.";
            pauseText.SetActive (true);
            button.SetActive (true);
            isPaused = true;
        }
    }

    void OnMouseExit() {
        pauseDisplay.SetActive(false);
        pauseText.SetActive(false);
        button.SetActive (false);
    }
}
