using System.Linq;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Slider slider;
    private float sliderValue = 6;
    public GameObject GameOverScreen;
    private float maxHealth = 6;
    public int HeartsCount = 6;
    public Image[] Hearts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider.value = sliderValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value == 0)
        {
            Debug.Log("Game Over");
            GameOverScreen.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            slider.value -= 1;
            sliderValue = slider.value;
            HeartsCount-= 1;
            Hearts[(int)slider.value].enabled = false;
        }
        if(collision.gameObject.CompareTag("Medkit"))
        {
            slider.value = maxHealth;
            sliderValue = slider.value;
            Destroy(collision.gameObject);
            for (int i = 0; i < 6; i++)
            {
                Hearts[(int)i].enabled = true;
            }
        }
    }
}
