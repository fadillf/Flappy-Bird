using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipa : MonoBehaviour
{
    public float delay;
    float timer;
    public GameObject pipa;
    float random;

    void Start()
    {
        timer = delay;
    }
    void Update()
    {
        if (timer <= 0)
        {
            random = Random.Range(-2.49f, 3.36f);
            Instantiate(pipa, new Vector2(transform.position.x, random), Quaternion.identity);
            timer = delay;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
