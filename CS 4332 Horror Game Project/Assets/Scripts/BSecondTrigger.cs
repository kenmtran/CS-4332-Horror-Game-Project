using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BSecondTrigger : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject TextBox;
    public AudioSource ScaryMusic;

    void OnTriggerEnter () {
        ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        ScaryMusic.Play();
        StartCoroutine (ScenePlayer());
        
        
    }

    IEnumerator ScenePlayer() {
        TextBox.GetComponent<Text>().text = "What is this pillar?";
        yield return new WaitForSeconds (5.0f);
        TextBox.GetComponent<Text> ().text = "";
        ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
    }
}
