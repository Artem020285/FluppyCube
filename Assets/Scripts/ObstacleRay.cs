using System;

using UnityEngine;

public class ObstacleRay : MonoBehaviour
{
    
    [SerializeField] private float _rayLenght;

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.up * _rayLenght, Color.red);

        bool hit = Physics.Raycast(transform.position, transform.up, out var ray, _rayLenght);
        if(hit)
        {
            if (ray.collider == null && ray.collider.tag == "Player");
        }
    }
}
