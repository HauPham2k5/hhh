using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int scorevalue = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Circle"))
        {
            playerData.playerScore++;
            ScoreController.Instance.IncreaseScore(scorevalue);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag.Equals("Pinwheel"))
        {
            playerData.playerScore++;
            ScoreController.Instance.IncreaseScore(scorevalue);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag.Equals("Box"))
        {
            Debug.Log("xx111");
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MapEdge"))
        {
            Destroy(gameObject);
        }
    }
}

