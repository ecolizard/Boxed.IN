using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject asteroidPrefab;

    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Spawn();
        }

        mousePos = Input.mousePosition;
    }

    void Spawn()
    {
        GameObject asteroid = Instantiate(asteroidPrefab, mousePos, Quaternion.identity);
    }

}   

