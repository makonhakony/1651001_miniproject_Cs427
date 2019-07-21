using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public string LevelName;
    public GameObject player;
    void Start()
    {
        player = GameObject.Find("player");
        StartCoroutine(wait());
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D objects)
    {
        if (objects.CompareTag("Player"))
        {
            player.GetComponent<Animator>().SetTrigger("dead");
            StartCoroutine(wait());
            SceneManager.LoadScene(LevelName);
            life_count.lifenum--;
        }
    }
    
    IEnumerator wait()
    {
        Debug.Log("yes");
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }

}
