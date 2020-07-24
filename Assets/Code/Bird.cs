﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Vector3 initialPosition;

    private void Awake() {
        initialPosition = transform.position;
    }

    private void OnMouseDown(){
        GetComponent<SpriteRenderer>().color = Color.red;
        
    }
    
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        Vector2 directionToInitialPosition = initialPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * 100);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    private void OnMouseDrag() {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y);
    }
}
