using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject grPipe;
    public float maxTime;
    float timer;
    public float height;
    

    private void Start()
    {
        timer = maxTime;
    }
    private void Update()
    {
        if (timer > maxTime)
        {
            GameObject tmp = Instantiate(grPipe, new Vector3(transform.position.x, transform.position.y + Random.Range(-height, height), 0), Quaternion.identity);
            Destroy(tmp, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
