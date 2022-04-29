using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehivour : MovementBehaviour
{
    [SerializeField]
    private int _speed;
    [SerializeField]
    private Transform _target;

    public Transform Target
    {
        get {return _target; }
        set {_target = value; }
    }

    public int Speed
    {
        get {return _speed; }
        set { _speed = value;}
    }

    // Update is called once per frame
    public void Update()
    {
        Vector3 distance = Target.position - transform.position;
        Velocity = distance.normalized * Speed;
        base.Update();
    }
}
