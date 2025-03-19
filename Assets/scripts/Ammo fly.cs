using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammofly : MonoBehaviour
{
    public float Ammo_speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Ammo_speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
         Destroy(collision.gameObject);
        }
    }

}