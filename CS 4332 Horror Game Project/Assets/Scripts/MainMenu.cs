using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        //Cursor.visible = true;
    }
   public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
