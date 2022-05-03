using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour

{
    public static Player playerInstance;

    //interact with NPC
    public bool interactNPC;
    public bool interactMusic = false;


    //canvas setActive:

    public Canvas hintCanvas1;
    public Canvas hintCanvas2;
    public Canvas hintCanvas3;
    public Canvas hintCanvas4;
    public Canvas hintCanvas5;

    //exit gate
    public Canvas exitCanvas;
    public AudioSource winningAudio;
    public AudioSource failWarningAudio;
    public AudioSource BGM;
    public Canvas scoreBaord;

    //interact with keys:
    public int keyCounter = 0;
    public Text textNumerator;
    public AudioSource pickUpKey;
    private GameObject NPCOnDestory=null;

    


    private void Awake()
    {

        ShowMouse();
        interactNPC = false;
        playerInstance = this;
        hintCanvas1.gameObject.SetActive(false);
        hintCanvas2.gameObject.SetActive(false);
        hintCanvas3.gameObject.SetActive(false);
        hintCanvas4.gameObject.SetActive(false);
        hintCanvas5.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC1")
        {
            playerInstance.NPCOnDestory = other.gameObject;
            HintLight.hintLightInstance.interactNPC = true;
            hintCanvas1.gameObject.SetActive(true);
            ShowMouse();


        }
        if (other.tag == "NPC2")
        {
            playerInstance.NPCOnDestory = other.gameObject;
            HintLight2.hintLight2Instance.interactNPC = true;
            hintCanvas2.gameObject.SetActive(true);
            ShowMouse();
        }
        if (other.tag == "NPC3")
        {
            playerInstance.NPCOnDestory = other.gameObject;
            HintLight3.hintLight3Instance.interactNPC = true;
            hintCanvas3.gameObject.SetActive(true);
            ShowMouse();
        }
        if (other.tag == "NPC4")
        {
            playerInstance.NPCOnDestory = other.gameObject;
            HintLight4.hintLight4Instance.interactNPC = true;
            hintCanvas4.gameObject.SetActive(true);
            ShowMouse();
        }
        if (other.tag == "NPC5")
        {
            playerInstance.NPCOnDestory = other.gameObject;
            HintLight5.hintLight5Instance.interactNPC = true;
            hintCanvas5.gameObject.SetActive(true);
            ShowMouse();
        }


        if (other.tag == "Key1")
        {

            HintLight.hintLightInstance.interactNPC = false;

            playerInstance.keyCounter++;
            playerInstance.textNumerator.text = keyCounter.ToString();
            Destroy(other.gameObject);
            pickUpKey.Play();

            //destory the last NPC encountered:
            if (NPCOnDestory != null) Destroy(NPCOnDestory);

        }
        if (other.tag == "Key2")
        {

            HintLight2.hintLight2Instance.interactNPC = false;

            playerInstance.keyCounter++;
            playerInstance.textNumerator.text = keyCounter.ToString();
            Destroy(other.gameObject);
            pickUpKey.Play();

            //destory the last NPC encountered:
            if (NPCOnDestory != null) Destroy(NPCOnDestory);

        }
        if (other.tag == "Key3")
        {

            HintLight3.hintLight3Instance.interactNPC = false;

            playerInstance.keyCounter++;
            playerInstance.textNumerator.text = keyCounter.ToString();
            Destroy(other.gameObject);
            pickUpKey.Play();

            //destory the last NPC encountered:
            if (NPCOnDestory != null) Destroy(NPCOnDestory);

        }
        if (other.tag == "Key4")
        {

            HintLight4.hintLight4Instance.interactNPC = false;

            playerInstance.keyCounter++;
            playerInstance.textNumerator.text = keyCounter.ToString();
            Destroy(other.gameObject);
            pickUpKey.Play();

            //destory the last NPC encountered:
            if (NPCOnDestory != null) Destroy(NPCOnDestory);

        }
        if (other.tag == "Key5")
        {

            HintLight5.hintLight5Instance.interactNPC = false;

            playerInstance.keyCounter++;
            playerInstance.textNumerator.text = keyCounter.ToString();
            Destroy(other.gameObject);
            pickUpKey.Play();

            //destory the last NPC encountered:
            if (NPCOnDestory != null) Destroy(NPCOnDestory);

        }

        if (other.tag == "Gate")
        {
            if (playerInstance.keyCounter == 5) {
                exitCanvas.gameObject.SetActive(true);
                BGM.Stop();
                winningAudio.Play();
                
            }
            else // EXIT WARNING 
            {
                scoreBaord.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                failWarningAudio.Play();
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Gate")
        {
            scoreBaord.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }









    public void ShowMouse()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void HindMouse()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
