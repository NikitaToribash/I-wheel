using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed;//скорость перса
    [SerializeField] float _jumpForce;//сила прыжка
    public Rigidbody2D _rb;
    [SerializeField] bool isGrounded;
    public Transform feetpos;
    public LayerMask whatIsGround;
    public float checkRadius;
  


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * _speed);
    }
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetpos.position, checkRadius, whatIsGround);

       
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector2.up * _jumpForce;
            

        }
else if (isGrounded == true && Input.touchCount > 0) 
  {
            _rb.velocity = Vector2.up * _jumpForce;
        }
        }
   


    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Respawn")
{
            SceneManager.LoadScene(0);
        }

    }
}



   

