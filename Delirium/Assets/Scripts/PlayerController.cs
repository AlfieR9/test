using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public int gravityForce;
    public Rigidbody2D rb2d;
    public BoxCollider2D bc2d;
    public SpriteRenderer sprd;
    public Sprite standing;
    public Sprite crouching;
    public Sprite reaching;

    private bool facingLeft = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    private void movement()
    {

        if (Input.GetKey(KeyCode.S))
        {
            ChangeSprite(crouching);
            bc2d.offset = new Vector2(0, (float)-2.5);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            
            ChangeSprite(reaching);
            bc2d.offset = new Vector2(0, 4);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            
            ChangeSprite(standing);
            bc2d.offset = new Vector2(0, 1);
            rb2d.velocity = new Vector2(-MovementSpeed, rb2d.velocity.y);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            
            ChangeSprite(standing);
            bc2d.offset = new Vector2(0, 1);
            rb2d.velocity = new Vector2(MovementSpeed, rb2d.velocity.y);
        }
        else
        {
            ChangeSprite(standing);
            bc2d.offset = new Vector2(0, 1);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
    }

    private void ChangeSprite(Sprite state)
    {
        sprd.sprite = state;
    }

    private void Sensor()
    {
        RaycastHit2D rc2dGround = Physics2D.BoxCast();
    }
}
