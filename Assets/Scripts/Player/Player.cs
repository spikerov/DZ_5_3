using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private CoinSpawner _spawner;
    [SerializeField] private TMP_Text _coinsText;

    public Transform ShootPoint => _shootPoint;

    private Weapon _currentWeapon;
    private int _currentHealth;
    private int _coinCount;

    public Weapon CurrentWeapon => _currentWeapon;

    private void Start()
    {
        _currentWeapon = _weapons[0];
        _currentHealth = _health;
    }

    public void PickUpCoin()
    {
        _coinCount++;
        _coinsText.text = _coinCount.ToString();
        _spawner.SpawnCoin();
    }
}
