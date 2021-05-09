using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    /*
    public GameObject pauseDisplay;
    public GameObject pauseText;
    public GameObject button;
    private bool isPaused = false;
    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            pauseDisplay.SetActive (false);
            pauseText.SetActive (false);
            button.SetActive (false);
            startPause();
           
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
            pauseText.GetComponent<Text> ().text = "DO YOU WANT TO RESTART? PRESS 'R' TO CANCEL";
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
*/
    public void RestartGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
