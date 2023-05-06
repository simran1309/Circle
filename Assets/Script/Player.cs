
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 jumpForce;
    Vector2 currentVelocity;
    Rigidbody2D rgbd;
    GameManager gameManager;
    ScoreUI scoreUi;
    private Animator anim;
    public bool play = false;
   


    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.gravityScale = 0;
        gameManager = FindObjectOfType<GameManager>();
        scoreUi = FindObjectOfType<ScoreUI>();
        anim = GetComponent<Animator>();
        // anim.Play("Bounce");
     
        
            InvokeRepeating("addScore", 1.0f, 0.7f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver) {
            rgbd.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("color");
            play = false;
            return; }
        if (Input.GetMouseButtonDown(0))
        {   
            if (rgbd.gravityScale != 0.5f) { rgbd.gravityScale = 0.5f; }
            rgbd.AddForce(jumpForce);
            SpeedController();
           // scoreUi.IncrementScore(1);
            play = true;
            StopAnim();
          
        }
       
       
         
        

    }
    void SpeedController()
    {   
        currentVelocity = rgbd.velocity;
        currentVelocity.x = Mathf.Clamp(currentVelocity.x, 2, 2);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, 0, 2);
        rgbd.velocity = currentVelocity;
       
    }
    public void StopAnim()
    {
        anim.SetTrigger("idle");
    }
    public void addScore()
    {
        if (play)
        {
            scoreUi.IncrementScore(1);
        }
       
    }
   
}
