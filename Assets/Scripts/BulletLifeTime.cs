using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLifeTime : MonoBehaviour
{
    public float lifeTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyDelay", lifeTime);
    }

    private void DestroyDelay()
    {
        Destroy(gameObject);
    }
}
