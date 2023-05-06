
using UnityEngine;

public class ScorePointCanvas : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void DiamondHit(Vector2 position)
    {
        transform.position = position;
        animator.SetTrigger("Play");
    }
}
