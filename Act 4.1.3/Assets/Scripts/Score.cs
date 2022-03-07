using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [SerializeField] int ScoreNum;
    [SerializeField] Text ScoreText;
    [SerializeField] Text WinText; 
 
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        ScoreText.text = "Score : " + ScoreNum;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Increases the score each time you touch the object "Energy coin" 
        if (collision.tag == "EnergyCoin"){
            ScoreNum += 1;
            Destroy(collision.gameObject);
            ScoreText.text = "Score : " + ScoreNum; 
        }

        //Decrease the score each time you touch the enemies 
        if (collision.tag == "EnemyPlane"){
            ScoreNum -= 1;
            //Destroy(collision.gameObject);
            ScoreText.text = "Score : " + ScoreNum; 
        }

        // Winner text appears when goal is reached (ship) 
        if(collision.tag == "FinishMeta"){
            Destroy(collision.gameObject);
            ScoreText.text = "Score : Infinite :)"; 
            WinText.text = "You win!!! "; 
        }


    }
}
