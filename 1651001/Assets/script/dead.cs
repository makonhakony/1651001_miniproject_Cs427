using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public string LevelName;
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D objects)
    {
        if (objects.CompareTag("Player"))
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
