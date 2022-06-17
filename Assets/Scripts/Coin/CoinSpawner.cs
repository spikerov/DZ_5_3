using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private List<Transform> _coinSpawnPoints;
    [SerializeField] private Queue<Transform> _queueSpawnCoins = new Queue<Transform>();

    private void Start()
    {
        TransferListToQuewe();
        SpawnCoin();
    }

    private void TransferListToQuewe()
    {
        for (int i = 0; i < _coinSpawnPoints.Count; i++)
        {
            _queueSpawnCoins.Enqueue(_coinSpawnPoints[i]);
        }
    }

    public void SpawnCoin()
    {
        if (_queueSpawnCoins.Count != 0)
        {
            Instantiate(_coinPrefab, _queueSpawnCoins.Dequeue());
        }
    }
}
