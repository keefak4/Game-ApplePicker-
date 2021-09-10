using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed = 2.0f;
    public float _endX = 63.5f;
    private float _startX;


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if(transform.position.x <= _endX)
        {
            Vector2 pos = new Vector2(_startX, transform.position.y);
            transform.position = pos;
        }
    }
}
