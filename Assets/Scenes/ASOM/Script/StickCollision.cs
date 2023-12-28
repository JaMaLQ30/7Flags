using UnityEngine;

public class StickCollision : MonoBehaviour
{
    private bool isAttached = false;
    private GameObject player;
    private Vector3 offset;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isAttached && (collision.gameObject.CompareTag("Stick") || collision.gameObject.CompareTag("Wheel")))
        {
            isAttached = true;
            player = collision.gameObject;
            offset = player.transform.position - transform.position;
        }
    }

    private void Update()
    {
        if (isAttached && player != null)
        {
            player.transform.position = transform.position + offset;
            // ﬁ„ » Õ—Ìﬂ «·‹ player Â‰« Ê›ﬁ« ··≈œŒ«· √Ê «·‘—Êÿ «·Œ«’… »ﬂ
        }
    }
}