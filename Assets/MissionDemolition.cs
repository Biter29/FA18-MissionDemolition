using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum GameMode
{
    idle,
    playing,
    levelEnd
}
public class MissionDemolition : MonoBehaviour {
    static private MissionDemolition S;
    [Header("Set in Inspector")]
    public Text uitLevel;
    public Text uitShots;
    public text uitButton;
    public Vector3 castlePos;
    public GameObject[] castles;

    [Header("Set Dynamically")]
    public int level;
    public int levelMax;
    public int shotsTaken;
    public gameObject[] castle;
    public GameMode mode = GameMode.idle;
    public string showing = "Show Slingshot";
	// Use this for initialization
	void Start () {
        S = this;
        level = 0;
        levelMax = castles.Length;
        StartLevel();
	}

    void StartLevel()
    {
        if (castle != null)
        {
            Destory(castle);
        }

        GameObject gos = GameObject.FindGameObjectWithTag("Projectile");
        foreach(GameObject pTemp in gos)
        {
            Destroy(pTemp);
        }

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
