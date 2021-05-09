using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHome : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ErrorText;

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver() {
        if (Distance <=2) {
            ActionDisplay.SetActive (true);
            ActionText.GetComponent<Text> ().text = "Use 3 keys to get home.";
            ActionText.SetActive (true);
        }
        if (Input.GetButtonDown("Action")) {
            if (Distance <= 2 && CollectKey.keyCount == 3) {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ErrorText.GetComponent<Text> ().text = "Victory!";
                ErrorText.SetActive (true);
                Time.timeScale = 0;
            }
            else {
                ActionText.SetActive(false);
                ErrorText.GetComponent<Text> ().text = "You do not have 3 keys.";
                ErrorText.SetActive(true);
            }
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ErrorText.SetActive(false);
    }
}
