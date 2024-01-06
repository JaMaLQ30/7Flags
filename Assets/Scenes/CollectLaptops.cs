using UnityEngine;
using UnityEngine.UI;

public class CollectLapTops : MonoBehaviour
{
    public int laptopValue = 1;  // ���� ������ ������� ������
    private int totalLaptops = 0;  // ����� �������� ������� �������� �������

    public Text laptopCountText;  // ���� ��� ��� ��� ������� ��������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Laptop"))  // ���� ��� ��� ��� ������ ���� �� ������� �� �� ���� �����
        {
            CollectLaptop();  // ������� ������ ���� ������ �������
            Destroy(other.gameObject);  // ����� ������ ������� ����� ����
        }
    }

    private void CollectLaptop()
    {
        totalLaptops += laptopValue;  // ����� ����� �������� ������� ��������
        UpdateLaptopCountText();  // ����� �� ��� ��� ������� ��������
    }

    private void UpdateLaptopCountText()
    {
        laptopCountText.text = "Laptops: " + totalLaptops.ToString();  // ����� �� ��� ��� ������� �������� ��� ����� ��������
    }
}