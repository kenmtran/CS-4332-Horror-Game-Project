using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpFlashlight : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject fakeFlashlight;
    public GameObject realFlashlight;
    public GameObject guideArrow;

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver() {
        if (Distance <=2) {
            ActionDisplay.SetActive (true);
            ActionText.GetComponent<Text> ().text = "Pick up flashlight";
            ActionText.SetActive (true);
        }
        if (Input.GetButtonDown("Action")) {
            if (Distance <= 2) {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                fakeFlashlight.SetActive(false);
                realFlashlight.SetActive(true);
            }
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
