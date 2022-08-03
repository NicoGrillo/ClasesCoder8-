using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMov : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        Move(speed);
    }

    private void Move(float speedValue)
    {
        transform.Translate(Vector3.forward * speedValue * Time.deltaTime);
    }

}

