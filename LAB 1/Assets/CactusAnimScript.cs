using UnityEngine;

public class Fight : MonoBehaviour
{
    private Animator _mAnimator;
    public Transform otherCactus;

    // Start is called before the first frame update
    void Start()
    {
        _mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_mAnimator != null)
        {
            if (Vector3.Distance(transform.position, otherCactus.position) <= 0.4f)
            {
                _mAnimator.SetBool("isAttacking", true);
            }
            else
            {
                _mAnimator.SetBool("isAttacking", false);
            }
        }
    }
}