using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class TEST : MonoBehaviour
{
    public static int CountDigit;
    public GameObject CountDisplay;
    public int InternalCount;
    void Update()
    {
        InternalCount = CountDigit;
        CountDisplay.GetComponent<Text>().text ="" + InternalCount;
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    
}
}
