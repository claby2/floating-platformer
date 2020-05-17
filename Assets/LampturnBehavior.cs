using System.Collections;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine;

public class LampturnBehavior : MonoBehaviour {

    public Light2D Light;

    private float lightStepChange = 0.5f;
    private float lightStep = 0.5f;

    void Update() {

        Light.intensity -= lightStep * Time.deltaTime;

        if(Light.intensity < 0.6f) {
            lightStep = -lightStepChange;
        } else if(Light.intensity > 1.0f) {
            lightStep = lightStepChange;
        }
        
    }
}
