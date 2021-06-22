using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalkInSceneChange : MonoBehaviour
{
    public LevelChanger levelChanger;

    private void Start()
    {
        levelChanger  = GameObject.Find("LevelChanger").GetComponent<LevelChanger>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            levelChanger.FadeToLevel(4); // loads MageCastle scene When player enter the trigger collider
            Debug.Log("Load Mage Castle Level");
        }
    }

}
