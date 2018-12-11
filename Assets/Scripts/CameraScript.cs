using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    [SerializeField] private Vector2 cameraSpeed;
    [SerializeField] private Vector2 direction;
	
	void Update () {
		
        Vector2 cameraMouvement = new Vector2( cameraSpeed.x * direction.x, cameraSpeed.y * direction.y);

	    cameraMouvement *= Time.deltaTime;
        transform.Translate(cameraMouvement);
	}
}
