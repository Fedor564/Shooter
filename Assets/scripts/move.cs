using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int Speed = 5;
    private Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;


    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        transform.LookAt(player);
        if (transform.position.x > 17)
        {
            Destroy(gameObject);
        }
    }
}
