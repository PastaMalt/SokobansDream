using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public Sprite[] backgrounds;
    private Vector2 startPosition;
    private float backgroundWidth;
    private int currentIndex = 0;

    void Start()
    {
        startPosition = transform.position;
        
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        backgroundWidth = spriteRenderer.bounds.size.x;

      
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, backgroundWidth * 2);
        transform.position = startPosition + Vector2.left * newPosition;

       
    }

   
}
