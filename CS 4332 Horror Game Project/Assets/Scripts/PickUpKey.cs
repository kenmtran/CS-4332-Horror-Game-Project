using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKey : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject rustKey;
    //public GameObject counter;
    //public static uint keyCount = 0;

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver() {
        if (Distance <=3) {
            ActionDisplay.SetActive (true);
            ActionText.GetComponent<Text> ().text = "Pick up key";
            ActionText.SetActive (true);
        }
        if (Input.GetButtonDown("Action")) {
            if (Distance <= 3) {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                rustKey.SetActive(false);
                //counter.GetComponent<Text>().text = keyCount.ToString();
                CollectKey.keyCount += 1;

            }
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
