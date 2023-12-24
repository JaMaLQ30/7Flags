using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosqueSound : MonoBehaviour
{
    public Transform player; // ����� ������ ���� ������
    public Transform mosque; // ����� ������ ���� ������
    public AudioSource audioSource; // ����� ����� �����

    public float maxDistance = 10f; // ������� ������ �����
    public float minDistance = 1f; // ������� ������ �����

    private void Update()
    {
        // ���� ������� ��� ������ �������
        float distance = Vector3.Distance(player.position, mosque.position);

        // ����� ��� ����� ����� ��� �������
        float volume = Mathf.Lerp(0f, 1f, (maxDistance - distance) / (maxDistance - minDistance));

        // ����� ��� ����� �� ���� �����
        audioSource.volume = volume;
    }
}
