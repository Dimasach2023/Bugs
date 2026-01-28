using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
public class Boss : MonoBehaviour
{
    public Slider slider;
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
        float horizontal = Input.GetAxis("Horizontal");

        if (slider.value == 1 && GameObject.FindGameObjectWithTag("Apple"))
        {
            
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("Apple").transform.position , speed);
            
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, positions[indexPosition], speed);
        }
        if (transform.position == positions[indexPosition])
        {

            if (indexPosition < positions.Length - 1)
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

        
        
        if(slider.value == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            slider.value -= 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            slider.value = 3;
            Destroy(collision.gameObject);
        }
    }
}
