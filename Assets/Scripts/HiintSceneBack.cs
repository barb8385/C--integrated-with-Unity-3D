using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**attach this class to Buttons **/
public class HiintSceneBack : MonoBehaviour
{
    //public Button backButton1;
    public Canvas canvas1;

    
    public void goBack()
    {
        HindMouse();
        canvas1.gameObject.SetActive(false);
        
    }

    public void HindMouse()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
