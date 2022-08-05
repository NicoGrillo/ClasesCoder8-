using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    [SerializeField] [Range(2f, 10f)] float cooldown = 2f;
    [SerializeField] Transform nextPortal;
    [SerializeField] float timeInPortal = 0f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrando en Trigger con ->" + other.gameObject.name);
        timeInPortal = 0f;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Saliendo de Trigger con ->" + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Estando en Trigger con ->" + other.gameObject.name);
        timeInPortal += Time.deltaTime;
        if (timeInPortal >= cooldown)
        {
            other.transform.position = nextPortal.position;
        }
    }
}