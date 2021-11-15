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

    private void Start()
    {
        _moveController = _player.GetComponent<MoveController>();
    }
    enum ButtonType
    {
        Up,
        Down
    }

    private void FixedUpdate()
    {
        if (isOn && _moveController.IsAir)
        {
            switch (_type)
            {
                case ButtonType.Down:
                    _player.transform.Rotate(0f, 0f, -_rotateSpeed, Space.World);
                    break;
                case ButtonType.Up:
                    _player.transform.Rotate(0f, 0f, _rotateSpeed, Space.World);
                    break;
            }
        }
        if (isOn)
            Debug.Log("タッチされた");
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
