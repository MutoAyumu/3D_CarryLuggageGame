using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    bool isOn;

    private void FixedUpdate()
    {
        if (isOn)
            Debug.Log("タッチされた");
    }
    public void Down()
    {
        isOn = true;
    }
    public void Up()
    {
        isOn = false;
    }
}
