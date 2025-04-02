using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Animals;
    public int index;
    private Vector3 position;
    void Start()
    {
        InvokeRepeating("spawn", 2, 2);





    }
    void spawn()
    {
        index = Random.Range(0, Animals.Length);
        position = new Vector3(Random.Range(-40, -30), 10, Random.Range(100, 155));
        Quaternion Rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(Animals[index], position, Rotation);
    }
}