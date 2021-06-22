using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartCollectorManager : MonoBehaviour
{
    public int coinsCollected = 0;
    public int partsCollected = 0;
    public bool bugPiece = false;
    public bool mazePiece = false;
    public bool castlePiece = false;

    public int bugsKilled = 0;
    public int skeletonsKilled = 0;

    private static GameObject instance;

    public UnityEngine.Events.UnityEvent showBugPiece;
    public UnityEngine.Events.UnityEvent showCastlePiece;
    public UnityEngine.Events.UnityEvent showMazePiece;
    public UnityEngine.Events.UnityEvent showEscapePrompt;

    private Text coinCounter;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
            instance = gameObject;
        else
            Destroy(gameObject);

        coinCounter = GameObject.Find("coinCounter").GetComponent<Text>();
        coinCounter.text = "Coins: " + coinsCollected;
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = "Coins: " + coinsCollected;
        if(bugPiece&&castlePiece&&mazePiece)
        {
            showEscapePrompt.Invoke();
        }
    }

    public void pickupCoin()
    {
        coinsCollected++;
        Debug.Log("Coins: " + coinsCollected);
    }

    public void killBug()
    {
        bugsKilled++;
        Debug.Log("Bug kill recorded");
    }

    public void killSkeleton()
    {
        skeletonsKilled++;
        Debug.Log("skeleton kill recorded");
    }

    public void collectBugPiece()
    {
        bugPiece = true;
        showBugPiece.Invoke();
        Debug.Log("Bugs life part collected");
        partsCollected++;
    }

    public void collectCastlePiece()
    {
        castlePiece = true;
        showCastlePiece.Invoke();
        Debug.Log("Mage Castle part collected");
        partsCollected++;
    }

    public void collectMazePiece()
    {
        mazePiece = true;
        showMazePiece.Invoke();
        Debug.Log("Maze part collected");
        partsCollected++;
    }
}
