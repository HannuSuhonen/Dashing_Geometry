using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviour : MonoBehaviour
{
    void Update()
    {
        float moveSpeed = Random.Range(1f,10f);
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
