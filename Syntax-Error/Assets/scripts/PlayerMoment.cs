using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    private Rigidbody2D body;
    private Vector3 Scale;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }
    private void Start()
    {
        Scale = transform.localScale;
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, body.velocity.y);

        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(Scale.x,Scale.y,Scale.z);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-Scale.x,Scale.y, Scale.z);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
            body.velocity = new Vector2(body.velocity.x, jump);

        
    }
}
