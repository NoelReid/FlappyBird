using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}