using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammofly : MonoBehaviour
{
    public float Ammo_speed = 1f;

    void Update()
    {
        Debug.Log("llllllllllllllllllllllllllllllllllllllll");
        transform.Translate(Vector3.forward * Time.deltaTime * Ammo_speed);
    }
}