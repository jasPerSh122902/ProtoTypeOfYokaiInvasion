using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 _velocity;

    public Vector3 Veclicty 
    {
        get {return _velocity; }
        set {value = _velocity; }
    }
    // Update is called once per frame

    void Update()
    {
        transform.position += _velocity * Time.deltaTime;
    }
}
