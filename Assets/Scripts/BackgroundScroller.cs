using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        LoadBackground();
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, backgroundWidth * 2);
        transform.position = startPosition + Vector2.left * newPosition;

        if (transform.position.x <= startPosition.x - backgroundWidth) 
        {
            currentIndex = (currentIndex + 1) % backgrounds.Length;
            LoadBackground();
        }
    }

    void LoadBackground()
    {
        GetComponent<SpriteRenderer>().sprite = backgrounds[currentIndex];
    }
}
