using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Sumo")
        {
            Destroy(this);
        }
    }
}
