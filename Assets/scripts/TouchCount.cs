using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCount : MonoBehaviour
{
    public GameObject counter;

    public void TapIt ()
    {
        TEST.CountDigit += 1;
    }
}
