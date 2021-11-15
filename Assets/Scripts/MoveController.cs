using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    Rigidbody _rb = default;
    bool isAir;
    [SerializeField] float _moveSpeed = 10f;

    public bool IsAir { get => isAir; set => isAir = value; }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        var dir = Vector3.right * _moveSpeed;
        dir.y = _rb.velocity.y;
        _rb.velocity = dir;
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Crate"))
        {
            other.gameObject.transform.parent = null;
        }
        if(other.gameObject.CompareTag("Ground"))
        {
            IsAir = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsAir = false;
        }
    }
}
