using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speed;
    private Vector2 direction;
    private Vector3 desplazamiento;

    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Start()
    {      
        direction = new Vector2(1, 1);
    }

    void Update()
    {
        desplazamiento = new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;

        _compTransform.position = _compTransform.position + desplazamiento;
        

        
        if (_compTransform.position.x > 8.2f || _compTransform.position.x < -8.2f)
        {
            direction.x = direction.x * -1;

            if (_compSpriteRenderer.flipX)
            {
                _compSpriteRenderer.flipX = false; 
            }
            else
            {
                _compSpriteRenderer.flipX = true;
            }
        }

        if (_compTransform.position.y > 4.25f || _compTransform.position.y < -4.25f)

        {
            direction.y = direction.y * -1; 
        }
    }
}


