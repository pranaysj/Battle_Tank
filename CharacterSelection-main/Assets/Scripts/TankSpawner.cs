using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tank;

    void Start()
    {
        Instantiate(tank, transform.position, Quaternion.identity);
    }

}
