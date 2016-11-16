using UnityEngine;
using System.Collections;

public class CameraDisplayScript : MonoBehaviour {

    bool redVisible = true;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)) {
            if (!redVisible){
                Camera.main.cullingMask = 1 | 1 << 9;
                redVisible = true;
            }
            else {
                Camera.main.cullingMask = 1 | 1 << 8;
                redVisible = false;
            }
        }
	}
}
