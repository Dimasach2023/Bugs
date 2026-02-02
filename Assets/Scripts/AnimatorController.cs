using UnityEngine;

public class AnimatorController : MonoBehaviour
{

    public Animator playerAnimator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerAnimator.SetBool("Jump", true);
        }
        else
        {
            playerAnimator.SetBool("Jump", false);
            playerAnimator.SetBool("Idle", true);
        }
    }
}
