using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        speed = GameOptions.pinSpeed;
    }
    private void Update()
    {
       
        if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime); //how fast the pin flies
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform); //parents pin to rotator when stabbed
            Score.pinCount++;//collision.GetComponent<Rotator>().speed *= -1; //Changes rotator direction for every pin
            isPinned = true;
        }
        else if(collision.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
