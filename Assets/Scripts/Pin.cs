using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private bool isPinned = false;


    public AudioClip pinSound;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
            audioSource.PlayOneShot(pinSound);
        } else if (col.tag == "torpedo")
        {
            if (Data.BestScore < Data.score)
            {
                Data.BestScore = Data.score;
                
            }
            //Data.TimesAbducted++;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
