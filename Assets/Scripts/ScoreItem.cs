using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    [SerializeField] float _score = 100f;
    GameManager _gameManager = default;

    private void Start()
    {
        _gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(_gameManager == null)
            {
                Debug.LogError("ScoreSystemが取得出来ていません");
            }
            else
            {
                _gameManager.AddScore(_score);
            }

            Destroy(this.gameObject);
        }
    }
}
