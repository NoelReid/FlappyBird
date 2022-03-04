using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    public Sprite fly;
    public Sprite flap;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = fly;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spriteRenderer.sprite = flap;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            spriteRenderer.sprite = fly;
        }
    }
}