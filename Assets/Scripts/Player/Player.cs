using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private CanvasLevel _canvasLevel;
    [SerializeField] private GameObject _fist;
    [SerializeField] private GameObject _axe;
    [SerializeField] private GameObject _sword;
    [SerializeField] private GameObject _bow;
    [SerializeField] private ManagerSounds _managerSounds;
    [SerializeField] private AudioSource _takeDamageSound;
    [SerializeField] private ParticleSystem _hitEffect;
    [SerializeField] private ChangeSpriteAttackButton _changeSpriteAttackButton;
    [SerializeField] private ItemCollector _itemCollector;

    private int _coinCount;
    private int _currentWeaponNumber = 0;
    private Weapon _currentWeapon;
    private int _currentHealth;

    public Weapon CurrentWeapon => _currentWeapon;
    public int Coin => _coinCount;
    public int Health => _health;

    public event UnityAction<int> HealthChanged;
    public event UnityAction<int> CoinChanged;

    private void Start()
    {
        ChangeWeapon(_weapons[_currentWeaponNumber]);
        _currentHealth = _health;
    }

    public void PickUpObgect(string objectLabel)
    {
        _managerSounds.OnSoundPickUpObject();
        _itemCollector.SwitchCollectObject(objectLabel);
    }

    public void OnEnemyDied(int reward)
    {
        _coinCount += reward;
        _managerSounds.OnSoundGetCoin();
        _canvasLevel.AddCoin(_coinCount);
        CoinChanged?.Invoke(_coinCount);
    }

    public void BuyWeapon(Weapon weapon)
    {
        _coinCount -= weapon.Price;
        _weapons.Add(weapon);
        _canvasLevel.AddCoin(_coinCount);
        CoinChanged?.Invoke(_coinCount);
    }

    public void ApplyDamage(int damage)
    {
        _hitEffect.Play();
        _takeDamageSound.Play();
        _currentHealth -= damage;
        HealthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0)
            Die();
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }

    public void NextWeapon()
    {
        if (_currentWeaponNumber == _weapons.Count - 1)
            _currentWeaponNumber = 0;
        else
            _currentWeaponNumber++;

        ChangeWeapon(_weapons[_currentWeaponNumber]);
    }

    private void ChangeWeapon(Weapon weapon)
    {
        _currentWeapon = weapon;
        ChangeSpriteAttackButton();
    }

    private void ChangeSpriteAttackButton()
    {
        switch (_currentWeapon.Label)
        {
            case "Fist":
                _changeSpriteAttackButton.ChangeSpriteInOnSoundAttackFist();
                _fist.SetActive(true);
                _bow.SetActive(false);
                break;
            case "Axe":
                _changeSpriteAttackButton.ChangeSpriteInOnSoundAttackAxe();
                _fist.SetActive(false);
                _axe.SetActive(true);
                break;
            case "Sword":
                _changeSpriteAttackButton.ChangeSpriteInOnSoundAttackSword();
                _axe.SetActive(false);
                _sword.SetActive(true);
                break;
            case "Bow":
                _changeSpriteAttackButton.ChangeSpriteInOnSoundAttackBow();
                _sword.SetActive(false);
                _bow.SetActive(true);
                break;
        }
    }
}
