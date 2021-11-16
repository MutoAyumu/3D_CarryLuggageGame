using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] GameObject _player = default;
    [SerializeField] float _rotateSpeed = 2;
    bool isOn;
    [SerializeField] ButtonType _type;
    MoveController _moveController = default;
    Rigidbody _rb = default;

    private void Start()
    {
        _moveController = _player.GetComponent<MoveController>();
        _rb = _player.GetComponent<Rigidbody>();
    }
    enum ButtonType
    {
        Up,
        Down
    }
    //private void Update()
    //{
    //    if (Input.GetKey(KeyCode.P) || Input.GetKey(KeyCode.Q))
    //    {
    //        Down();
    //    }
    //    else
    //    {
    //        Up();
    //    }
    //}
    private void Update()
    {
        if (isOn && _moveController.IsAir)
        {
            switch (_type)
            {
                case ButtonType.Down:
                    _rb.angularVelocity = new Vector3(0f, 0f, -_rotateSpeed);
                    break;
                case ButtonType.Up:
                    _rb.angularVelocity = new Vector3(0f, 0f, _rotateSpeed);
                    break;
            }
        }
        if(_moveController.IsAir && Input.GetKey(KeyCode.P))
        {
            _rb.angularVelocity = new Vector3(0f, 0f, -_rotateSpeed);
        }
        if(_moveController.IsAir && Input.GetKey(KeyCode.Q))
        {
            _rb.angularVelocity = new Vector3(0f, 0f, _rotateSpeed);
        }
    }
    public void Down()
    {
        isOn = true;
    }
    public void Up()
    {
        isOn = false;
    }
}
