using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLightKeyMapping : MonoBehaviour
{
    
    public LightController correspondingLight; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LightController.staticInstance.interactNPC = true;
            LightController.staticInstance.audioFromLight.Play();
            
        }
    }
}
