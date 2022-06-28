using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinBalance : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinCount;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _coinCount.text = _player.Coin.ToString();
        _player.CoinChanged += OnCoinChenged;
    }

    private void OnDisable()
    {
        _player.CoinChanged -= OnCoinChenged;
    }

    private void OnCoinChenged(int coin)
    {
        _coinCount.text = coin.ToString();
    }
}
