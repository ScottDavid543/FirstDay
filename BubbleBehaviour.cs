using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BubbleBehaviour : MonoBehaviour {

    public Transform imagePos;
    public Image thisImage;

    public AIController kid;
    
    Camera cam;

	// Use this for initialization
	void Start () {
        cam = Camera.main;        
	}
	
	// Update is called once per frame
	void Update () {
        if (kid != null)
        {
            imagePos = kid.imagePos;
            Vector3 screenPos = cam.WorldToScreenPoint(imagePos.position);
            thisImage.transform.position = screenPos;

            if (kid.state == AIController.States.Want)
            {
                //float timer = kid.wantedItemWait / kid.wantedItemTimer;
                //float time = timer / 10;
                thisImage.fillAmount = kid.wantedItemTimer / kid.wantedItemWait;
            }
            if(kid.state == AIController.States.Crying)
            {
                thisImage.fillAmount = kid.cryingTimer / kid.cryingWait;
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
	}
}
