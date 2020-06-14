﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        FindObjectOfType<AudioManager>().Play("Die");
        SceneManager.LoadScene("GameOver");
    }
}