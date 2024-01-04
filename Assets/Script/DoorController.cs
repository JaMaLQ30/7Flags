using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f;  // ÒÇæíÉ İÊÍ ÇáÈÇÈ
    public float openSpeed = 2f;   // ÓÑÚÉ İÊÍ ÇáÈÇÈ

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
            // ÊÍÑíß ÇáÈÇÈ ÈÇÊÌÇå ÇáÒÇæíÉ ÇáãİÊæÍÉ
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, openSpeed * Time.deltaTime);
        }
        else
        {
            // ÅÚÇÏÉ ÊÍÑíß ÇáÈÇÈ Åáì æÖÚå ÇáÃæáí
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, openSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = true;  // ÊİÚíá İÊÍ ÇáÈÇÈ ÚäÏãÇ íÊİÇÚá ÇááÇÚÈ ãÚå
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = false;  // ÅáÛÇÁ İÊÍ ÇáÈÇÈ ÚäÏãÇ íÊæŞİ ÇááÇÚÈ Úä ÇáÊİÇÚá ãÚå
        }
    }
}