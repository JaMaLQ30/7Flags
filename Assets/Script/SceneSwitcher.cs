using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string targetSceneName; // ��� ����� ���� ���� �� �������� ����

    private void OnMouseDown()
    {
        SceneManager.LoadScene(targetSceneName); // ����� ����� ������
    }
}