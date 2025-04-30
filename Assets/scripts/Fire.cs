using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fire : MonoBehaviour
{
    public TextMeshProUGUI lable;
    public AudioSource ReloadSound;
    public AudioSource Shot;
    private bool ISreload = false;
    private float Reload = 4f;
    private float Cooldown = 1.5f;
    private int NowAmmo;
    private int MaxAmmo = 4;
    public GameObject Ammo;
    public GameObject Gun;
    private Quaternion rotation;
    void Start()
    {
        NowAmmo = MaxAmmo;
        lable.text = "Патроны " + NowAmmo.ToString();
    
    }
    void Update()
    {
        rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
           
        
        if (Input.GetMouseButtonDown(0) & Cooldown >= 1.5f & NowAmmo > 0 & ISreload == false)
        {
            Instantiate(Ammo, Gun.transform.position, rotation);
            NowAmmo--;
            Debug.Log(NowAmmo);
            Cooldown = 0f;
            Shot.Play();
            lable.text = "Патроны " + NowAmmo.ToString();
        }
        if (Input.GetKeyDown(KeyCode.R) & ISreload == false & NowAmmo == 0)
        {
            ISreload = true;

        }
        if (ISreload == true )
        {
            if (Reload > 2)
            {
                ReloadSound.Play();
            }
            Reload -= Time.deltaTime;
            if (Reload <= 0)
            {
                NowAmmo = MaxAmmo;
                ISreload = false;
                Reload = 4f;
                lable.text = "Патроны " + NowAmmo.ToString();
            }
        }
        if (Cooldown < 1.5f)
        {
            Cooldown += Time.deltaTime;
        }


    }

}
