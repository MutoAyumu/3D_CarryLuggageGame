using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateScript : MonoBehaviour
{
    [SerializeField] GameObject _particle = default;
    [SerializeField] float _destroyTime = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);

            if (_particle)
            {
                var obj = Instantiate(_particle, this.transform.position, Quaternion.identity);
                Destroy(obj, _destroyTime);
            }
        }
    }
}
