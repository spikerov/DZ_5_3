using UnityEngine;

public class Hedgehog : Enemy
{
    public override void OnWalkSound()
    {
        _angrySound.Stop();
        _walkSound.Play();
    }

    public override void OnAttackSound()
    {
        _walkSound.Stop();
        _angrySound.Play();
    }

    public override void TurnOffSounds()
    {
        _walkSound.Stop();
        _angrySound.Stop();
    }
}