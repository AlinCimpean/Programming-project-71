using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Showthermometer GetShowthermometer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetShowthermometer.Pressed();
        }
    }
}
