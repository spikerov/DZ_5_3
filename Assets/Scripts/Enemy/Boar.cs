using UnityEngine;

public class Boar : Enemy 
{
    public override void OnWalkSound()
    {
        _walkSound.Play();
        _angrySound.Stop();
    }

    public override void OnAttackSound()
    {
        _angrySound.Play();
        _walkSound.Stop();
    }

    public override void TurnOffSounds()
    {
        _walkSound.Stop();
        _angrySound.Stop();
    }
}