// PLAYER SCRIPT FROM "MAKE OBJECT MOVE" TUTORIAL

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 _moveDirection;
    
    
    // Start is called before the first frame update
    void Start()
    {
        inputManager.Init(this);
        inputManager.SetGameControls();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3) (speed * Time.deltaTime * _moveDirection);
    }

    public void SetMovementDirection(Vector2 currentDirection)
    {
        _moveDirection = currentDirection;
    }
    
    
    
}