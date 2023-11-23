using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplamasesi : MonoBehaviour
{

    AudioSource ses;
    public AudioClip sesdosyasi;
    public AudioClip sesdosyasi2;
    public AudioClip sesdosyasi3;

    private void Start()
    {
        ses = gameObject.GetComponent<AudioSource>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin1")
        {
            ses.PlayOneShot(sesdosyasi);
        }

        else if (collision.gameObject.tag == "zemin2")
        {
            ses.PlayOneShot(sesdosyasi2);
        }

        else if (collision.gameObject.tag == "zemin3")
        {
            ses.PlayOneShot(sesdosyasi3);
        }
    }




}
