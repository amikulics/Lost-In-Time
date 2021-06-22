using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PiecePickup : MonoBehaviour
{
    public PartCollectorManager partManagerScript;
    private Scene currScene;

    // Start is called before the first frame update
    void Start()
    {
        partManagerScript = GameObject.Find("PersistantObject").GetComponent<PartCollectorManager>();
        currScene = SceneManager.GetActiveScene();
        if(partManagerScript.bugPiece && currScene.name == "BugsLife")//ensures part cant be picked up twice
        {
            Destroy(gameObject);
        }
        if (partManagerScript.castlePiece && currScene.name == "MageCastle")
        {
            Destroy(gameObject);
        }
        if (partManagerScript.mazePiece && currScene.name == "MazeRunner")
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (currScene.name == "BugsLife")
            {
                partManagerScript.collectBugPiece();
                Destroy(gameObject);
            }
            else if(currScene.name =="MageCastle")
            {
                partManagerScript.collectCastlePiece();
                Destroy(gameObject);
            }
            else if (currScene.name == "MazeRunner")
            {
                partManagerScript.collectMazePiece();
                Destroy(gameObject);
            }
        }
    }
}
