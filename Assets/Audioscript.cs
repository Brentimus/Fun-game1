using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioscript : MonoBehaviour
{
    [SerializeField] AudioSource music;
    // Start is called before the first frame update
    void Awake()
    {
        music.Play();
    }
}
