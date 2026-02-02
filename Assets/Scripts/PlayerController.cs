using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int speed = 10;
    private SpriteRenderer sprite;
    private int force = 5;
    private Rigidbody2D rb;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();       
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontal);
        sprite.flipX = horizontal < 0;
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Castle"))
        {
            SceneManager.LoadScene("Game2");
        }
    }
}
