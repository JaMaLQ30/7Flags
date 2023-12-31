using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float sprintSpeed = 3f;
    public float jumpForce = 5f;
    public float mouseSensitivity = 2f;

    private Rigidbody rb;
    private Camera playerCamera;
    private float verticalRotation = 0f;
    private AudioSource audioSource;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerCamera = GetComponentInChildren<Camera>();
        // Cursor.lockState = CursorLockMode.Locked;

        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Mouse rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(0f, mouseX, 0f);

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = (transform.right * moveHorizontal + transform.forward * moveVertical).normalized;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.MovePosition(rb.position + movement * sprintSpeed * Time.deltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        }

        // Jumping
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

   
    }

    private bool IsGrounded()
    {
        RaycastHit hit;
        float raycastDistance = 1.1f;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
        {
            return true;
        }

        return false;
    }

    

}