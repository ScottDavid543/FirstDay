using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPos : MonoBehaviour {

    public Image button;
    public Transform buttonPos;

    Camera cam;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 screenPos = cam.WorldToScreenPoint(buttonPos.position);
        button.transform.position = screenPos;
    }
}
