using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour // даем системе понять, что это сетевой объект
{
    private float _speed = 5f;
    private float _horizontalInput;
    private float _verticalInput;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (isOwned)
        {
            _horizontalInput = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
            _verticalInput = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
            transform.Translate(new Vector2(_horizontalInput, _verticalInput));
        }
    }
}
