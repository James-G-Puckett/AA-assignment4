using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject torpedo;

    public AudioClip torpedoSound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
            audioSource.PlayOneShot(torpedoSound);
        }
    }
    void SpawnPin()
    {
        Instantiate(torpedo, transform.position, transform.rotation);
    }
}
