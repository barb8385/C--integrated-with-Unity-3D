using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintLight2 : MonoBehaviour
{
    public static HintLight2 hintLight2Instance;

    public bool interactNPC = false;
    private float highIntensity = 80.0f;
    private float aimIntensity;
    public float lightChangingSpeed = 10.0f;
    public AudioSource soundFromLight;

    private void Start()
    {
        aimIntensity = highIntensity;
        hintLight2Instance = this;

    }

    private void Update()
    {
        if (interactNPC == true)
        {
            if (this.gameObject.GetComponent<Light>().enabled == false)
            {

                this.gameObject.GetComponent<Light>().enabled = true;
                this.gameObject.GetComponent<Light>().intensity = 0;
            }

            if (!soundFromLight.isPlaying) soundFromLight.Play();

            this.gameObject.GetComponent<Light>().intensity = Mathf.Lerp(this.gameObject.GetComponent<Light>().intensity, aimIntensity, lightChangingSpeed * Time.deltaTime);


            if (Mathf.Abs(aimIntensity - this.gameObject.GetComponent<Light>().intensity) <= 0.05)
            {
                if (aimIntensity == highIntensity) aimIntensity = 0.0f;
                else if (aimIntensity == 0.0f) aimIntensity = highIntensity;
            }
        }
        else
        {
            this.gameObject.GetComponent<Light>().enabled = false;
            soundFromLight.Stop();
        }
    }
}
