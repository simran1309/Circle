using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
    
{
    public ParticleSystem ps;
    public BoxCollider2D DiamondCollider;
    // Start is called before the first frame update
    void Start()
    {
        DiamondCollider.enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "PointColliders")
        {

            //add points
            Debug.Log("yay");
            FindObjectOfType<ScoreUI>().IncrementDiamond(1);
            FindObjectOfType<ScorePointCanvas>().DiamondHit(collision.transform.position);
            Destroy(gameObject);
        }
       else if (collision.tag == "DeadColliders")
        {
            
            Debug.Log("smash");
            ps.Play();
            DiamondCollider.enabled = false;
           gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.5f);
           
            
        }
    }
 
}
