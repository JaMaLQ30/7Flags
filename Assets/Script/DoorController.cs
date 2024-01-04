using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f;  // ����� ��� �����
    public float openSpeed = 2f;   // ���� ��� �����

    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private bool isOpen = false;

    private void Start()
    {
        initialRotation = transform.rotation;
        targetRotation = Quaternion.Euler(0f, openAngle, 0f);
    }

    private void Update()
    {
        if (isOpen)
        {
            // ����� ����� ������ ������� ��������
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, openSpeed * Time.deltaTime);
        }
        else
        {
            // ����� ����� ����� ��� ���� ������
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, openSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = true;  // ����� ��� ����� ����� ������ ������ ���
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = false;  // ����� ��� ����� ����� ����� ������ �� ������� ���
        }
    }
}