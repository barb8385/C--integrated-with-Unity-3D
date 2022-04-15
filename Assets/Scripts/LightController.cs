using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to the NPC

public class LightController : MonoBehaviour


{
    // static attribute
    public static LightController staticInstance;

    public GameObject correspondingLight;

    //lights attributs :
    public bool interactNPC=false ;
    public float lightChangingSpeed=10;

    private float lowIntensity=10;
    private float highIntensity = 80;
    private float aimIntensity ;

    public Light myLight;

    //sounds attributes:
    //public AudioClip audioInteractNPC;
    public AudioSource audioFromLight;

    //NPC positon attirbute:
    //public Vector3 NPCPosition; 
    


    private void Awake()
    {
        aimIntensity = highIntensity;
        //interactNPC = false;

        staticInstance = this;
        myLight = GetComponent<Light>();
        //NPCPosition = this.GetComponent<Transform>().position;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            staticInstance.interactNPC = true;
            staticInstance.audioFromLight.Play();

        }
    }

    private void Update()
    {
        if(interactNPC)
        {

            myLight.intensity = Mathf.PingPong(80.0f,3.0f); //light 
                
            if (Mathf.Abs(aimIntensity - staticInstance.GetComponent<Light>().intensity) <= 0.05)
            {
                if (aimIntensity == highIntensity) aimIntensity = lowIntensity;
                else if (aimIntensity == lowIntensity) aimIntensity = highIntensity;
            }
        }
        else
        {
            myLight.intensity = Mathf.Lerp(myLight.intensity, 0, Time.deltaTime * lightChangingSpeed);
            
        }
        
        

        // light gradually turn off: 
        // staticInstance.myLight.intensity = Mathf.Lerp(staticInstance.myLight.intensity, 0, Time.deltaTime); 



    }


}
