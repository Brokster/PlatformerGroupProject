using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelSwitchingScript : MonoBehaviour
{
    public bool stage1 = false;
    public bool stage2 = false;
    public bool stage3 = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fire1")
        {
            SceneManager.LoadScene("stageSelect");
            stage1 = true;
        }
        if (collision.gameObject.tag == "water1")
        {
            SceneManager.LoadScene("stageSelect");
            stage2 = true;
        }
        if (collision.gameObject.tag == "sand1")
        {
            SceneManager.LoadScene("stageSelect");
            stage3 = true;
        }
   
    }
}
