using UnityEngine;
using UnityEngine.UI;

public class ChangeSpriteButtonSound : MonoBehaviour
{
    [Header("Image Fof Change")]
    [SerializeField] private Image _image;
    [Header("Sprite Sound On")]
    [SerializeField] private Sprite _imageSoundOn;
    [Header("Sprite Sound Off")]
    [SerializeField] private Sprite _imageSoundOff;

    public void ChangeSpriteInOnSound()
    {
        _image.sprite = _imageSoundOn;
    }

    public void ChangeSpriteInOffSound()
    {
        _image.sprite = _imageSoundOff;
    }
}
