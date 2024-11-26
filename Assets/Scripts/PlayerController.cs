using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;
    [SerializeField] private float jumpForce;
    [SerializeField] private float runSpeed;
    [SerializeField] private ForceMode2D forceMode;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask jumpLayerMask;

    private bool isGrounded = false;

    void OnValidate()
    {
        if (body == null)
        {
            body = GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, jumpLayerMask);
        //Debug.DrawRay(transform.position, Vector2.down * groundCheckDistance, Color.red);

        RaycastHit2D hitInfoBoxCast
            = Physics2D.BoxCast(transform.position, new Vector2(transform.localScale.x, groundCheckDistance
            ), 0, Vector2.down, groundCheckDistance, jumpLayerMask);

        if (hitInfoBoxCast.collider != null)
        {
            print(hitInfoBoxCast.collider);
        }

        if (isGrounded = hitInfoBoxCast.collider != null)
        {
            //print(hitInfo.collider.name);
            Debug.DrawLine(transform.position, hitInfoBoxCast.point, Color.green);
        }

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            body.AddForce(Vector2.up * jumpForce, forceMode);
        }

    }

    private void FixedUpdate()
    {
        if (Input.GetKey("left"))
        {
            body.AddForce(Vector2.left * runSpeed * Time.deltaTime, ForceMode2D.Force);
        }
        if (Input.GetKey("right"))
        {
            body.AddForce(Vector2.right * runSpeed * Time.deltaTime, ForceMode2D.Force);
        }
    }
}
