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
        // ���� ��� ���� CharacterController ������ �������
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // ������ ��� ����� ��������
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // ����� ������
        MovePlayer(verticalInput, horizontalInput);
    }

    void MovePlayer(float verticalInput, float horizontalInput)
    {
        // ���� ������ �������� CharacterController
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        movement = transform.TransformDirection(movement);
        movement *= moveSpeed;

        // ����� ������
        characterController.Move(movement * Time.deltaTime);

        // ����� ������ ��� ���� Y
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);
    }
}
