using UnityEngine;
using TMPro;
public class BaseHealth : MonoBehaviour
{
    private static int lives = 6;
    public TextMeshProUGUI liveText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lives--;
            if (lives <= 0)
            {
                Debug.Log("GameOver");
            }
        }
        if (collision.gameObject.CompareTag("Medkit"))
        {
            lives = 6;
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        liveText.text = "Lives: " + lives.ToString();
    }
}

