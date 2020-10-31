using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDropper : MonoBehaviour
{
    public GameObject foodToDrop;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 foodPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            foodPosition.z = 0f;
            Debug.Log("mousePos: " + foodPosition);
            Instantiate(foodToDrop, foodPosition, Quaternion.identity);
        }
    }
}
