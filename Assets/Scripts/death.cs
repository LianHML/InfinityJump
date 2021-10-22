using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    public GameObject GameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;

        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
