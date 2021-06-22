using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endScoreScreen : MonoBehaviour
{
    public PartCollectorManager partManagerScript;
    private Text bugsKilled;
    private Text skeletonsKilled;
    private Text coinsCollected;
    private Text total;

    int bugMultiplier = 10;
    int skeletonMultiplier = 5;

    GameObject mainUI;

    public LevelChanger levelChanger;

    // Start is called before the first frame update
    void Start()
    {
        partManagerScript = GameObject.Find("PersistantObject").GetComponent<PartCollectorManager>();
        bugsKilled = GameObject.Find("BugsKilledValue").GetComponent<Text>();
        skeletonsKilled = GameObject.Find("SkeletonsKilledValue").GetComponent<Text>();
        coinsCollected = GameObject.Find("coinsCollectedValue").GetComponent<Text>();
        total = GameObject.Find("totalScoreValue").GetComponent<Text>();

        bugsKilled.text = partManagerScript.bugsKilled.ToString();
        skeletonsKilled.text = partManagerScript.skeletonsKilled.ToString();
        coinsCollected.text = partManagerScript.coinsCollected.ToString();
        total.text = ((partManagerScript.bugsKilled*bugMultiplier)+(partManagerScript.skeletonsKilled*skeletonMultiplier) + (partManagerScript.coinsCollected)).ToString();

        mainUI = GameObject.Find("ObjectiveUI");
        mainUI.SetActive(false);

        levelChanger = GameObject.Find("LevelChanger").GetComponent<LevelChanger>();
        Cursor.lockState = CursorLockMode.None;
    }

 
    public void mainMenu()
    {
        //SceneManager.LoadScene(0);
        levelChanger.FadeToLevel(0);
    }
}
