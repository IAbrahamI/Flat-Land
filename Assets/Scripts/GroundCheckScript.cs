using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GroundCheckScript : MonoBehaviour
{
    GameObject Player;
    private int extraJumps;
    private int extraJumpsValue;
    public float XCheckpointValue;
    public float YCheckpointValue;
    public TextMeshProUGUI textscore;
    public int coinValue = 1;
    public string sceneName;
    public int score;
    public int ScoreValue;
    public int CompletetLevels = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<Movement>().isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Platform")
        {
            Player.GetComponent<Movement>().isGrounded = true;
        }
        if (sceneName.Equals("Lv01"))
        {
            if (collision.collider.tag == "KillZone")
            {
                SceneManager.LoadScene("Lv01");
                score = 0;
            }

        }else if (sceneName.Equals("Lv02"))
        {
            if (collision.collider.tag == "KillZone")
            {
                SceneManager.LoadScene("Lv02");
                score = 0;
            }
        }else if (sceneName.Equals("Lv03"))
        {
            if (collision.collider.tag == "KillZone")
            {
                SceneManager.LoadScene("Lv03");
                score = 0;
            }
        }else if (sceneName.Equals("Lv04"))
        {
            if (collision.collider.tag == "KillZone")
            {
                SceneManager.LoadScene("Lv04");
                score = 0;
            }
        }else if (sceneName.Equals("Lv05"))
        {
            if (collision.collider.tag == "KillZone")
            {
                SceneManager.LoadScene("Lv05");
                score = 0;
            }
        }

        if (collision.collider.tag == "Goal")
        {
            SceneManager.LoadScene("LevelMenu");
            ScoreValue += score;
            score = 0;
            CompletetLevels++;
            Debug.Log(CompletetLevels);
        }
        if(collision.collider.tag == "FinalGoal")
        {
            SceneManager.LoadScene("FinalStage");
            ScoreValue += score;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {
            Player.GetComponent<Movement>().isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
}
