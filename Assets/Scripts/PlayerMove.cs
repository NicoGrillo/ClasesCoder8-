using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector3 position;
    public int scale = 2;
    public float speed = 1f;
    public int hp = 3;
    public int attack = 3;
    public int heal = 3;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        Reposition(position);
        Scaling(scale);
    }

    // Update is called once per frame
    void Update()
    {
        Movement(direction);
        Damage(attack);
        Heal(heal);
    }

    private void Movement(Vector3 value)
    {
        //transform.position += value * speed * Time.deltaTime;
        transform.Translate(value * speed * Time.deltaTime);
    }

    void Damage(int value)
    {
        hp -= value;
        //Debug.Log(hp);
    }

    void Heal(int value)
    {
        hp += value;
        //Debug.Log(hp);
    }

    private void Reposition(Vector3 value)
    {
        transform.position = value;
    }

    void Scaling(int value)
    {
        transform.localScale = transform.localScale * value;
    }
}
