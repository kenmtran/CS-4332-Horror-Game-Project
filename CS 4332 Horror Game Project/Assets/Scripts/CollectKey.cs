using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectKey : MonoBehaviour
{
    public static uint keyCount = 0;
    public GameObject counter;
    // Update is called once per frame
    void Update()
    {
        counter.GetComponent<Text>().text = keyCount.ToString();
    }
}
