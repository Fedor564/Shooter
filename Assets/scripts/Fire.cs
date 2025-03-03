using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Ammo;
    public GameObject Gun;
    private Quaternion rotation;
    void Update()
    {
        rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
           
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Ammo, Gun.transform.position, rotation);
        }
            
    }

}
