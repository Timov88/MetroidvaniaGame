using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{ 
    public AudioSource jumpSound;
    public AudioSource attackswordSound;
    public AudioSource attackGunSound;
    public AudioSource hurtSound;
    public AudioSource deathSound;
    public AudioSource parrySound;
    public AudioSource dashSound;

    public void PlayjumpSound()
    {
        jumpSound.Play();
    }

    public void PlayattackswordSound()
    {
        attackswordSound.Play();
    }
    public void PlayattackGunSound()
    {
        attackGunSound.Play();
    }
    public void PlayhurtSound()
    {
        hurtSound.Play();
    }
    public void PlaydeathSound()
    {
        deathSound.Play();
    }
    public void PlayparrySound()
    {
        parrySound.Play();
    }
    public void PlaydashSound()
    {
        dashSound.Play();
    }
}