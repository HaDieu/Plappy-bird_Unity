using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
