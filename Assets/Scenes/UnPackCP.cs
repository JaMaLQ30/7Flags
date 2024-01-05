using UnityEngine;

public class SeparateOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform child = transform.GetChild(0); // ÇİÊÑÇÖ Ãä ÇáÜ child åæ ÇáİÑÚ ÇáÃæá İí ÇáÜ parent
            child.parent = null; // İÕá ÇáÜ child Úä ÇáÜ parent
        }
    }
}