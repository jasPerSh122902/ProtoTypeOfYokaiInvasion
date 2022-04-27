using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MovementBehaviour1
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector2 _moveDirection;

    Vector2 MoveDirection 
    {
        get {return _moveDirection; }
        set {value = _moveDirection; }
    }
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
    }
}
