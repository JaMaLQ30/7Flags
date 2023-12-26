using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 700.0f;
    private CharacterController characterController;

    void Start()
    {
        // «Õ’· ⁄·Ï „ﬂÊ‰ CharacterController «·„—›ﬁ »«··«⁄»
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // «·Õ’Ê· ⁄·Ï ≈œŒ«· «·„” Œœ„
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        //  Õ—Ìﬂ «··«⁄»
        MovePlayer(verticalInput, horizontalInput);
    }

    void MovePlayer(float verticalInput, float horizontalInput)
    {
        // Õ”«» «·Õ—ﬂ… »«” Œœ«„ CharacterController
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        movement = transform.TransformDirection(movement);
        movement *= moveSpeed;

        //  Õ—Ìﬂ «··«⁄»
        characterController.Move(movement * Time.deltaTime);

        // œÊ—«‰ «··«⁄» ÕÊ· „ÕÊ— Y
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
