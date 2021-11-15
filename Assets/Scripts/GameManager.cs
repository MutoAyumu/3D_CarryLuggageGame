using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float _currntScore;

    [SerializeField] Text _scoreText = default;

    private void Start()
    {
        _scoreText.text = _currntScore.ToString();
    }

    public void AddScore(float score)
    {
        _currntScore += score;
        _scoreText.text = _currntScore.ToString();
    }
}
