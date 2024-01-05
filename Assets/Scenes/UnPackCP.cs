using UnityEngine;

public class SeparateOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform child = transform.GetChild(0); // ������ �� ��� child �� ����� ����� �� ��� parent
            child.parent = null; // ��� ��� child �� ��� parent
        }
    }
}