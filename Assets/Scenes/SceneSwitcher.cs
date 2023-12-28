using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string targetSceneName; // ÇÓã ÇáÓíä ÇáĞí ÊÑÛÈ İí ÇáÇäÊŞÇá Åáíå

    private void OnMouseDown()
    {
        SceneManager.LoadScene(targetSceneName); // ÊÍãíá ÇáÓíä ÇáÌÏíÏ
    }
}