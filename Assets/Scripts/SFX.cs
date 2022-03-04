using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip splatSFX;
    public bool dead = false;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if ((Input.GetButtonDown("Fire1") || Input.GetMouseButtonDown(0)) && dead == false)
        {
            GetComponent<AudioSource>().Play();
        }
        Vector2 stagePos = Camera.main.WorldToScreenPoint(transform.position);
        if ((stagePos.y > Screen.height || stagePos.y < 0) && dead == false)
        {
            dead = true;
            audioSource.PlayOneShot(splatSFX, 1);
        }
    }
}