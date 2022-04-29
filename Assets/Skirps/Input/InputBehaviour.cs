using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playermovementBehvour;

    private void Awake()
    {
        _playermovementBehvour = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _playermovementBehvour.MoveDirection = new Vector3((int)Input.GetAxisRaw("Horizontal"), 0, 0).normalized;
        }
      
    }
}
