using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoController : MonoBehaviour
{
    [SerializeField]
    private Transform destination;

    [SerializeField]
    private float movementSpeed = 5f;

    Vector3 direction;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = destination.position - transform.position;
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction.normalized * movementSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Food")
        {
            rb.mass += 1;
        }
    }
}
