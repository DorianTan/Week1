using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehavior : MonoBehaviour
{
    [SerializeField] private float spikeSpeed;
    [SerializeField] private Rigidbody2D spikeBody;

    private void Start()
    {
        spikeBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        spikeBody.velocity = new Vector2(spikeSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D spikeColision)
    {
        if (spikeColision.gameObject.name == "Player")
        {
            GameManager.lives -= 1;
        }

        if (spikeColision.gameObject.name == "Enemy")
        {
            Destroy(spikeColision.gameObject);
        }
    }
}