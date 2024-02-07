using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject objectToSpawn; // Drag the prefab you want to instantiate into this field
    void Start()
    {
        StartCoroutine(SpawnSpikes());
    }

    IEnumerator SpawnSpikes()
    {
        while (true) // Infinite loop to keep spawning spikes
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);

            float interval = Random.Range(1f, 3f);

            yield return new WaitForSeconds(interval);
        }
    }
}
