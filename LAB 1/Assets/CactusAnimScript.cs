using UnityEngine;

public class Fight : MonoBehaviour
{
    private Animator CactusAnimator;
    public Transform Cactus2;

    // Start is called before the first frame update
    void Start()
    {
        CactusAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CactusAnimator != null)
        {
            if (Vector3.Distance(transform.position, Cactus2.position) <= 0.4f)
            {
                CactusAnimator.SetBool("isAttacking", true);
            }
            else
            {
                CactusAnimator.SetBool("isAttacking", false);
            }
        }
    }
}