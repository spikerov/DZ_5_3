using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelController : MonoBehaviour
{
    private int _sceneIndex;
    private int _reachedLevels;

    private void Start()
    {

        _sceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        _reachedLevels = PlayerPrefs.GetInt("ReachedLevels");
    }

    public void IsEndLevel()
    {
        if (_reachedLevels < _sceneIndex)
        {
            PlayerPrefs.SetInt("ReachedLevels", _sceneIndex);
        }
    }
}
