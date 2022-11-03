using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BallBounce : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreManager scoreManager;
    public GameObject hitSFX;

    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if(collision.gameObject.name == "Player 1")
        {
            positionX = 1;
            ballMovement.IncreaseHitCounter();
        }

        else
        {
            positionX = -1;
            ballMovement.IncreaseHitCounter();
        }

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;

        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player 1 " || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
            ballMovement.IncreaseHitCounter();
        }

        else if(collision.gameObject.name == "Right Border")
        {
            scoreManager.Player1Goal();
            ballMovement.player1Start = false;
            StartCoroutine(ballMovement.Launch());
        }
        else if(collision.gameObject.name == "Right Border1")
        {
           scoreManager.Player3Goal();
           ballMovement.player1Start = true;
           StartCoroutine(ballMovement.Launch());
        }

        // else
        // {
        //     scoreManager.Player3Goal();
        //      ballMovement.player1Start = true;
        //      
        //  }

        Instantiate(hitSFX, transform.position, transform.rotation);
            

        
       
    }
}
