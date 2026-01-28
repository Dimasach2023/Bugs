using UnityEngine;

public class Animate : MonoBehaviour
{
    private Animator playerAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerAnimator.SetBool("Jump", true);
            playerAnimator.SetTrigger("Jump");
        }
    }

}
