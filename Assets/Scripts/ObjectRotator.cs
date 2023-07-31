using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed=10;
    [SerializeField] private Vector3 rotation = Vector3.up;

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * rotation, Space.Self);
    }
}
