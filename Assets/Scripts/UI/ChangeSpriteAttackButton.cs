using UnityEngine;
using UnityEngine.UI;

public class ChangeSpriteAttackButton : MonoBehaviour
{
    [Header("Image Fof Change")]
    [SerializeField] private Image _image;
    [Header("Sprite Attack Fist")]
    [SerializeField] private Sprite _spriteAttackFist;
    [Header("Sprite Attack Axe")]
    [SerializeField] private Sprite _spriteAttackAxe;
    [Header("Sprite Attack Sword")]
    [SerializeField] private Sprite _spriteAttackSword;
    [Header("Sprite Attack Bow")]
    [SerializeField] private Sprite _spriteAttackBow;

    public void ChangeSpriteInOnSoundAttackFist()
    {
        _image.sprite = _spriteAttackFist;
    }

    public void ChangeSpriteInOnSoundAttackAxe()
    {
        _image.sprite = _spriteAttackAxe;
    }

    public void ChangeSpriteInOnSoundAttackSword()
    {
        _image.sprite = _spriteAttackSword;
    }

    public void ChangeSpriteInOnSoundAttackBow()
    {
        _image.sprite = _spriteAttackBow;
    }
}

