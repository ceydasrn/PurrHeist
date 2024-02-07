using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPosition : MonoBehaviour
{
    public float speed;

    public void Start()
    {
        Destroy(gameObject, 10);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
