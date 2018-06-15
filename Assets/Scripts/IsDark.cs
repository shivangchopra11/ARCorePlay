using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleARCore;

public class IsDark : MonoBehaviour {

    private float LightThreshold = 0.4f;
    void Start () {
        this.GetComponent<Text>().enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
        if (Frame.LightEstimate.PixelIntensity < LightThreshold)
        {
            this.GetComponent<Text>().text = "DARK " + Frame.LightEstimate.PixelIntensity.ToString();
        }
        else
        {
            this.GetComponent<Text>().text = "LIGHT " + Frame.LightEstimate.PixelIntensity.ToString();
        } 
        
    }
}
