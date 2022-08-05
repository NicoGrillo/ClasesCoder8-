using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)] float speed = 1f;
    /*
    [SerializeField]
    [Range(0, 2)] int typeEnemy = 0;
    */
    enum ZombieTypes { Crawler, Stalker, Rioter }

    [SerializeField] ZombieTypes zombieTypes;

    [SerializeField] Transform playerTransform;


    void Start()
    {
        /* 
        if (typeEnemy == 0)
        {
            Debug.Log(name + "-> Mover Fordward");
        }
        if (typeEnemy == 1)
        {
            Debug.Log(name + "-> Seguir al Jugador");
        }
        if (typeEnemy == 2)
        {
            Debug.Log(name + "-> Rodear al Jugador");
        }
        */
        /*
        switch (typeEnemy)
        {
            case 0:
                Debug.Log(name + "-> Mover Fordward"); break;
            case 1:
                Debug.Log(name + "-> Seguir al Jugador"); break;
            case 2:
                Debug.Log(name + "-> Rodear al Jugador"); break;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        switch (zombieTypes)
        {
            case ZombieTypes.Crawler:
                MoveForward(); break;
            case ZombieTypes.Stalker:
                ChasePlayer(); break;
            case ZombieTypes.Rioter:
                RotateAroundPlayer(); break;
        }
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void ChasePlayer()
    {
        LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 1f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    private void RotateAroundPlayer()
    {
        LookPlayer();
        transform.RotateAround(playerTransform.position, Vector3.up, 5f * Time.deltaTime);
    }

    private void LookPlayer()
    {
        transform.LookAt(playerTransform);
    }
}
