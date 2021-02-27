using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{ 
    public AudioSource JumpSound;
    public AudioSource AttackswordSound;
    public AudioSource AttackGunSound;
    public AudioSource HurtSound;
    public AudioSource DeathSound;
    public AudioSource ParrySound;
    public AudioSource DashSound;
    public AudioSource MoveGrassSound;
    public AudioSource WitchLaugh;

    public void PlayJumpSound()
    {
        JumpSound.Play();
    }

    public void PlayAttackSwordSound()
    {
        AttackswordSound.Play();
    }
    public void PlayAttackGunSound()
    {
        AttackGunSound.Play();
    }
    public void PlayHurtSound()
    {
        HurtSound.Play();
    }
    public void PlayDeathSound()
    {
        DeathSound.Play();
    }
    public void PlayParrySound()
    {
        ParrySound.Play();
    }
    public void PlayDashSound()
    {
        DashSound.Play();
    }
    public void PlayMoveGrassSound()
    {
      //  Debug.Log("hölöhölö");
        MoveGrassSound.Play();
    }
    public void PlayWitchLaugh()
    {
        WitchLaugh.Play();
    }
}
