using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField] ProgressBar pb;
    [SerializeField] int itemVal = 10;
    [SerializeField] MeshRenderer meshRenderer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            pb.Val += itemVal;
            audioSource.Play();
            GetComponent<BoxCollider2D>().enabled = false;
            meshRenderer.enabled = false;
            Destroy(gameObject, audioSource.clip.length);
        }
    }
}
