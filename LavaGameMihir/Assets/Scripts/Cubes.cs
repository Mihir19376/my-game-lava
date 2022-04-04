using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public float delay = 1f;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(cube, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
    }
}
    