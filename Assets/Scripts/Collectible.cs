using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private int count = 0;
    [SerializeField] private AudioClip sound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible")) 
        {
            Debug.Log(count);
            count++;
            AudioSource.PlayClipAtPoint(sound, other.transform.position);
            Destroy(other.gameObject);
        }
    }
}
