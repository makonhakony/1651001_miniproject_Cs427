using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class life_count : MonoBehaviour
{
    public static int lifenum = 2;
    public Text lifetext;
    private Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        lifetext.text = "Life: " + lifenum;
        bool showed=false;
        if (lifenum < 0 && !showed)
        {
            if (scene.name == "level1")
            {
                lifetext.text += "\n (Calm down... and 1 more tip: try to stand on the edge)";
                showed = true;
            }
            if (scene.name == "level2")
            {
                showed = true;
                lifetext.text += "\n (Sometimes, we dont need to go up)";
            }
            if (scene.name == "level3")
            {
                showed = true;
                lifetext.text += "\n (The ice is slippery, slow down guys)";
            }
            if (scene.name == "level4")
            {
                showed = true;
                lifetext.text += "\n (Take a time, look around)";
                
            }
        }
    }
}
