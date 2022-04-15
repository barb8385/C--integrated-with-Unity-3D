using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hindsound : MonoBehaviour
{

    private AudioSource audioSrc;
    void Start()
    {

        audioSrc = GetComponent<AudioSource>();
    }
}
