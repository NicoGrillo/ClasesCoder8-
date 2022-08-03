using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject munition;
    public float shootDelay = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Scale();
        }
        Invoke("Shoot", shootDelay);
    }

    private void Shoot()
    {
        Instantiate(munition, transform.position, transform.rotation);
    }

    private void Scale()
    {
        munition.transform.localScale = munition.transform.localScale * 2;
    }

}
