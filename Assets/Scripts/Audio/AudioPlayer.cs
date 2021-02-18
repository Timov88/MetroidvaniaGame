using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    AudioController audio;

    private void Start()
    {
        audio = GetComponentInChildren<AudioController>();
    }
    public void JumpSound()
    {
        audio.PlayJumpSound();
    }
    public void AttackSwordSound()
    {
        audio.PlayAttackSwordSound();
    }
    public void AttackGunSound()
    {
        audio.PlayAttackGunSound();
    }
    public void HurtSound()
    {
        audio.PlayHurtSound();
    }
    public void DeathSound()
    {
        audio.PlayDeathSound();
    }
    public void ParrySound()
    {
        audio.PlayParrySound();
    }
    public void DashSound()
    {
        audio.PlayDashSound();
    }
    public void MoveGrassSound()
    {
        Debug.Log(audio.gameObject);
        audio.PlayMoveGrassSound();
    }
}
