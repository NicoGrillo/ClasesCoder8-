using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    [SerializeField] float timeToDestroy = 0;

    void Start()
    {
        Invoke("DestroyObject", timeToDestroy);
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
