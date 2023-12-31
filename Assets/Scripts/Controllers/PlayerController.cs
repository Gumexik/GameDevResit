using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 7f;

    private bool isWalking;

    // Update is called once per frame
    private void Update()
    {
        Vector2 inputVector = new Vector2(0,0);

        if (Input.GetKey(KeyCode.W)) {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) {
            inputVector.x = +1;
        }
    
        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime; 


        isWalking = moveDir != Vector3.zero;

// Raycast from the mouse position to the world
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    if (Physics.Raycast(ray, out RaycastHit hit))
    {
        // Calculate the direction to the cursor position
        Vector3 targetDirection = hit.point - transform.position;
        targetDirection.y = 0f; // Ensure character stays upright

        // Rotate the character to face the cursor position
        if (targetDirection != Vector3.zero)
        {
            float rotateSpeed = 12f;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotateSpeed);
        }
    }


    }
        public bool IsWalking() {
            return isWalking;
        }
}
