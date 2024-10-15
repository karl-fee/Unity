
using Mono.Cecil;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    private Vector2 _moveDirection;
    public InputActionReference move;
    public InputActionReference fire;

    private void Update() {
        _moveDirection =  move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.angularVelocity = new Vector3(_moveDirection.x * moveSpeed, 0, _moveDirection.y * moveSpeed);
    }

    private void OnEnable() {
        fire.action.started += Fire;
    }
    
    private void OnDisable() {
        fire.action.started -= Fire;
    }
    private void Fire(InputAction.CallbackContext obj) {
        Debug.Log("Fire!!");
    }
}
