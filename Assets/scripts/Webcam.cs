using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour {

	// Use this for initialization
	void Start () {

        WebCamTexture webcamTexture = new WebCamTexture();

        Debug.Log("Webcam: " + webcamTexture.deviceName);

        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();

	}
	
}
