﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flip_dead : MonoBehaviour
{
    // Start is called before the first frame update
    public string LevelName;
    public GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
    }
    

    // Update is called once per frame
    void Update()
    {
        if (player.transform.eulerAngles.z > 76 && player.transform.eulerAngles.z < 290)
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
