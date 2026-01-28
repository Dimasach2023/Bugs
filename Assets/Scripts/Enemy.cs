using UnityEngine;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float speed = 0.1f;
    public Vector3[] positions;
    private int indexPosition;
    private SpriteRenderer flip;

    void Start()
    {
        flip = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[indexPosition], speed);
        float horizontal = Input.GetAxis("Horizontal");
        if (transform.position == positions[indexPosition])
        {
            if(indexPosition < positions.Length - 1)
            {
                indexPosition++;
                flip.flipX = false;
            }
            else
            {
                indexPosition = 0;
                flip.flipX = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
