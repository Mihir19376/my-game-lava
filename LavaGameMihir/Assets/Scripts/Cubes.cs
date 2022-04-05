using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public float spawn_interval_time = 1;
    public GameObject cube;
    public int damage = 5;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, spawn_interval_time);
    }

    // Spawn Function
    void Spawn()
    {
        Instantiate(cube, new Vector2(Random.Range(-5, 5), 10), Quaternion.identity);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        collision.GetComponent<playerScript>().currentHealth -= damage;
    //    }
    //}


}
