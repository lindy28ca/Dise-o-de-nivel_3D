using UnityEngine;

public class Coin : MonoBehaviour
{
private SphereCollider scoll;

    private void Awake()
    {
        scoll = GetComponent<SphereCollider>();
    }

    private void Start()
    {
        scoll.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (scoll != null && other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
