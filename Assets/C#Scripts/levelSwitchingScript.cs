using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelSwitchingScript : MonoBehaviour
{
    public bool fire1complete = false;
    public bool fire2complete = false;
    public bool water1complete = false;
    public bool water2complete = false;
    public bool sand1complete = false;
    public bool sand2complete = false;





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fire1")
        {
            SceneManager.LoadScene("stageSelect");
            bool fire1complete = true;
        }
        if (collision.gameObject.tag == "fire2")
        {
            SceneManager.LoadScene("stageSelect");
            bool fire2complete = true;
        }
        if (collision.gameObject.tag == "water1")
        {
            SceneManager.LoadScene("stageSelect");
            bool water1complete = true;
        }
        if (collision.gameObject.tag == "water2")
        {
            SceneManager.LoadScene("stageSelect");
            bool water2complete = true;
        }
        if (collision.gameObject.tag == "sand1")
        {
            SceneManager.LoadScene("stageSelect");
            bool sand1complete = true;
        }
        if (collision.gameObject.tag == "sand2")
        {
            SceneManager.LoadScene("stageSelect");
            bool sand2complete = true;
        }
    }
}
