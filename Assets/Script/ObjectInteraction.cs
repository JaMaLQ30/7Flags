using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    private bool isHolding = false;
    private GameObject objectInHand;
    private Transform objectOriginalParent;

    void Update()
    {
        // «›Õ’ ≈–«  „ «·‰ﬁ— ⁄·Ï “— «·„«Ê” «·√Ì”—
        if (Input.GetMouseButtonDown(0))
        {
            if (isHolding)
            {
                Drop();
            }
            else
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("Pickupable"))
                    {
                        PickUp(hit.collider.gameObject);
                    }
                }
            }
        }
    }

    void PickUp(GameObject objectToPickup)
    {
        objectInHand = objectToPickup;
        objectOriginalParent = objectInHand.transform.parent;

        objectInHand.transform.SetParent(transform); // ÌÃ⁄· «·ﬂ«∆‰  «»⁄« ··ﬂ«∆‰ «·√» (·«⁄»)
        objectInHand.transform.localPosition = Vector3.zero;
        objectInHand.GetComponent<Rigidbody>().isKinematic = true;

        isHolding = true;
    }

    void Drop()
    {
        objectInHand.transform.SetParent(objectOriginalParent);
        objectInHand.GetComponent<Rigidbody>().isKinematic = false;

        objectInHand = null;
        objectOriginalParent = null;

        isHolding = false;
    }
}
