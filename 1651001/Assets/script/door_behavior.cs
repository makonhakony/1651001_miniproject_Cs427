using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door_behavior : MonoBehaviour
{
    // Start is called before the first frame update
    //public int index;
    public string levelName;
    void OnTriggerEnter2D(Collider2D door)
    {

        if (door.CompareTag("Player"))
        {
            //SceneManager.LoadScene(index);
            SceneManager.LoadScene(levelName);
            life_count.lifenum = 2;
        }
    }
}
