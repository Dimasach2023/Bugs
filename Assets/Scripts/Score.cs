using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private int coins;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        coins = 0;
        scoreText.text = coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins++;
            scoreText.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}
