using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private int NowAmmo;
    private int MaxAmmo = 8;
    public GameObject Ammo;
    public GameObject Gun;
    private Quaternion rotation;
    void Start()
    {
        NowAmmo = MaxAmmo;
    
    
    }
    void Update()
    {
        rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
           
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Ammo, Gun.transform.position, rotation);
            NowAmmo--;
            Debug.Lsssssssog(NowAmmo);
        }
            
    }

}
