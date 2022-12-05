
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosiotion;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
            transform.position = _spawnPosiotion.position;
    }
}
