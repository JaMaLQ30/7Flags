using UnityEngine;
using UnityEngine.UI;

public class CollectLapTops : MonoBehaviour
{
    public int laptopValue = 1;  // ÞםדÉ ÇבÌוÇÒ ÇבדÍדזב ÇבזÇÍÏ
    private int totalLaptops = 0;  // ÇבÚÏÏ ÇבÅÌדÇבם בבÃÌוÒÉ ÇבדÍדזבÉ ÇבדÌדÚÉ

    public Text laptopCountText;  // דÑÌÚ בהÕ ÚÑÖ ÚÏÏ ÇבÃÌוÒÉ ÇבדÍדזבÉ

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Laptop"))  // ÊÍÞÞ דדÇ ÅÐÇ ‗Çה Çב‗ÇÆה ÇבÐם Êד ÇבÊÕÇÏד Èו וז ÌוÇÒ דÍדזב
        {
            CollectLaptop();  // ÇÓÊÏÚÇÁ ÇבÏÇבÉ בÌדÚ ÇבÌוÇÒ ÇבדÍדזב
            Destroy(other.gameObject);  // ÊÏדםÑ ÇבÌוÇÒ ÇבדÍדזב ÈדÌÑÏ ÌדÚו
        }
    }

    private void CollectLaptop()
    {
        totalLaptops += laptopValue;  // ÒםÇÏÉ ÇבÚÏÏ ÇבÅÌדÇבם בבÃÌוÒÉ ÇבדÍדזבÉ
        UpdateLaptopCountText();  // ÊÍÏםË הÕ ÚÑÖ ÚÏÏ ÇבÃÌוÒÉ ÇבדÍדזבÉ
    }

    private void UpdateLaptopCountText()
    {
        laptopCountText.text = "Laptops: " + totalLaptops.ToString();  // ÊÍÏםË הÕ ÚÑÖ ÚÏÏ ÇבÃÌוÒÉ ÇבדÍדזבÉ Úבל זÇÌוÉ ÇבדÓÊÎÏד
    }
}