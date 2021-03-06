using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovementBehaviour : MovementBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
    }
   
}
