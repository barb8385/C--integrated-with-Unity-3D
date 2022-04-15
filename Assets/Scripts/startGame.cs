using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/** attach this to start Button**/

public class startGame : MonoBehaviour
{
    public Canvas startCanvas;
    public AudioSource BGM;

    private void Update()
    {
        showMouse();
    }

    public void StartButton()
    {
        startCanvas.gameObject.SetActive(false);
        hideMouse();
        BGM.Play();
    }

    // Update is called once per frame
    public void showMouse()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void hideMouse()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
