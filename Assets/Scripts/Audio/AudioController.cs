using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{ 
    public AudioSource jumpSound;

    public void PlayjumpSound()
    {
        jumpSound.Play();
    }


}