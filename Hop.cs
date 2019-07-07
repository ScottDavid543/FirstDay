using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hop : MonoBehaviour {

    public float hopTimer;
    public float hopSpeed;

    public GameObject body;

    void Start () {
        hopTimer = hopSpeed;
    }
	
	void Update () {
        hopTimer -= Time.deltaTime;
        if (hopTimer <= 0)
        {
            if (body.transform.position.y == 0)
            {
                body.transform.position = new Vector3(body.transform.position.x, 0.15f, body.transform.position.z);
                hopTimer = hopSpeed;
            }
            else
            {
                body.transform.position = new Vector3(body.transform.position.x, 0f, body.transform.position.z);
                hopTimer = hopSpeed;
            }
        }
    }
}
