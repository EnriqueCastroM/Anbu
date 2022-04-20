using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibleitem : MonoBehaviour
{
    public float healthRestoration = 1f;
    public GameObject lightingParticles;
    public GameObject burstParticles;

    private SpriteRenderer _renderer;
    private Collider2D _collider;


    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //cure player
            collision.SendMessageUpwards("AddHealth", healthRestoration);

            //disable collider
            _collider.enabled = false;

            //visual stuff
            _renderer.enabled = false;
            lightingParticles.SetActive(false);
            burstParticles.SetActive(true);

            //destroy after sometime
            Destroy(gameObject, 2f);
        }
    }


}
