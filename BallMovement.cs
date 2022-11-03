using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{
    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;

    public bool player1Start = true;

    private int hitcounter = 0;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(Launch());
    }

    private void RestartBall()
        {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }


    public IEnumerator Launch()
    {
        RestartBall();
        hitcounter = 0;
        yield return new WaitForSeconds(1);
        

        if (player1Start == true)
        {
            MoveBall(new Vector2(-1, 0));
        }
       
        else 
        {
            MoveBall(new Vector2(1, 0));
        }
    }

 


    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballspeed = startSpeed + hitcounter * extraSpeed;
       

        rb.velocity = direction * ballspeed;
        

    }

    public void IncreaseHitCounter()
    {
        if(hitcounter * extraSpeed < maxExtraSpeed)
        {
            hitcounter++;
        }
    }
   
}
