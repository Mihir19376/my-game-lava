using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public float spawn_interval_time = 1f;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawn_interval_time, spawn_interval_time);
    }

    // Spawn Function
    void Spawn()
    {
        Instantiate(cube, new Vector2(Random.Range(-5, 5), 10), Quaternion.identity);
    }

}
