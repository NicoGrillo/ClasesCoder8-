using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerData playerData;

    private void Start()
    {
        playerData = GetComponent<PlayerData>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entrando en colision con ->" + other.gameObject.name);
        if (other.gameObject.CompareTag("Enemies"))
        {
            Destroy(other.gameObject);
            playerData.Healing(1);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("En colision con ->" + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("Saliendo de colision con ->" + other.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }
}
