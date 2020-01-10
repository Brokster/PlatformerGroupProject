using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "b1goal")
        {
            SceneManager.LoadScene("board-2");
        }
        if (collision.gameObject.tag == "b2goal")
        {
            SceneManager.LoadScene("board-3");
        }
        if (collision.gameObject.tag == "b3goal")
        {
            SceneManager.LoadScene("win");
        }
    }
   
}
