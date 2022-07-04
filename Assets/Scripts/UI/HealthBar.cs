using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += OnValueChange;
        _slider.value = _player.Health;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnValueChange;
    }

    public void OnValueChange(int value)
    {
        _slider.value = value;
    }
}
