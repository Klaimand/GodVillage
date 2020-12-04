using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KLD_GameManager : MonoBehaviour
{
    [Header("Ressources"), SerializeField]
    Ressource ressources;

    [Space(10), SerializeField]
    int curVillageLevel;

    [SerializeField]
    Ressource[] ressourcesPerLevel;

    public GameObject[] RessourceUIParents;


    TMP_Text curNourritureText, neededNourritureText;
    TMP_Text curBoisText, neededBoisText;
    TMP_Text curPierreText, neededPierreText;
    TMP_Text curBronzeText, neededBronzeText;
    TMP_Text curFerText, neededFerText;
    TMP_Text curObsidienneText, neededObsidienneText;
    TMP_Text curAstateText, neededAstateText;


    [SerializeField]
    GameObject[] towers;

    public Transform simulationCam;

    //public List<List<GameObject>> ressourcesPrefabs = new List<List<GameObject>>();
    public List<PrefabVariants> ressourcesPrefabs = new List<PrefabVariants>();

    /*
    public enum RessourceType
    {
        NOURRITURE,
        BOIS,
        PIERRE,
        BRONZE,
        FER,
        OBSIDIENNE,
        ASTATE
    }*/


    // Start is called before the first frame update
    void Start()
    {
        //initializeTextes();
        //updateTowerUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void initializeTextes()
    {
        curNourritureText = RessourceUIParents[0].transform.GetChild(0).GetComponent<TMP_Text>();
        neededNourritureText = RessourceUIParents[0].transform.GetChild(2).GetComponent<TMP_Text>();

        curBoisText = RessourceUIParents[1].transform.GetChild(0).GetComponent<TMP_Text>();
        neededBoisText = RessourceUIParents[1].transform.GetChild(2).GetComponent<TMP_Text>();

        curPierreText = RessourceUIParents[2].transform.GetChild(0).GetComponent<TMP_Text>();
        neededPierreText = RessourceUIParents[2].transform.GetChild(2).GetComponent<TMP_Text>();

        curBronzeText = RessourceUIParents[3].transform.GetChild(0).GetComponent<TMP_Text>();
        neededBronzeText = RessourceUIParents[3].transform.GetChild(2).GetComponent<TMP_Text>();

        curFerText = RessourceUIParents[4].transform.GetChild(0).GetComponent<TMP_Text>();
        neededFerText = RessourceUIParents[4].transform.GetChild(2).GetComponent<TMP_Text>();

        curObsidienneText = RessourceUIParents[5].transform.GetChild(0).GetComponent<TMP_Text>();
        neededObsidienneText = RessourceUIParents[5].transform.GetChild(2).GetComponent<TMP_Text>();

        curAstateText = RessourceUIParents[6].transform.GetChild(0).GetComponent<TMP_Text>();
        neededAstateText = RessourceUIParents[6].transform.GetChild(2).GetComponent<TMP_Text>();


    }

    #region RessourcesAddFunctions

    public void addNourriture(int _quantity)
    {
        ressources.nourriture += _quantity;
    }

    public void addBois(int _quantity)
    {
        ressources.bois += _quantity;
    }

    public void addPierre(int _quantity)
    {
        ressources.pierre += _quantity;
    }

    public void addBronze(int _quantity)
    {
        ressources.bronze += _quantity;
    }

    public void addFer(int _quantity)
    {
        ressources.fer += _quantity;
    }

    public void addObsidienne(int _quantity)
    {
        ressources.obsidienne += _quantity;
    }

    public void addAstate(int _quantity)
    {
        ressources.astate += _quantity;
    }

    #endregion


    public void tryToLevelUp()
    {
        if (ressources.nourriture >= ressourcesPerLevel[curVillageLevel].nourriture &&
        ressources.bois >= ressourcesPerLevel[curVillageLevel].bois &&
        ressources.pierre >= ressourcesPerLevel[curVillageLevel].pierre &&
        ressources.bronze >= ressourcesPerLevel[curVillageLevel].bronze &&
        ressources.fer >= ressourcesPerLevel[curVillageLevel].fer &&
        ressources.obsidienne >= ressourcesPerLevel[curVillageLevel].obsidienne &&
        ressources.astate >= ressourcesPerLevel[curVillageLevel].astate)
        {
            ressources.nourriture -= ressourcesPerLevel[curVillageLevel].nourriture;
            ressources.bois -= ressourcesPerLevel[curVillageLevel].bois;
            ressources.pierre -= ressourcesPerLevel[curVillageLevel].pierre;
            ressources.bronze -= ressourcesPerLevel[curVillageLevel].bronze;
            ressources.fer -= ressourcesPerLevel[curVillageLevel].fer;
            ressources.obsidienne -= ressourcesPerLevel[curVillageLevel].obsidienne;
            ressources.astate -= ressourcesPerLevel[curVillageLevel].astate;

            curVillageLevel++;

            updateTowerModel();

        }
    }

    void updateTowerModel()
    {

    }

    public void updateTowerUI()
    {
        curNourritureText.text = ressources.nourriture.ToString();
        neededNourritureText.text = ressourcesPerLevel[curVillageLevel].nourriture.ToString();

        curBoisText.text = ressources.bois.ToString();
        neededBoisText.text = ressourcesPerLevel[curVillageLevel].bois.ToString();

        curPierreText.text = ressources.pierre.ToString();
        neededPierreText.text = ressourcesPerLevel[curVillageLevel].pierre.ToString();

        curBronzeText.text = ressources.bronze.ToString();
        neededBronzeText.text = ressourcesPerLevel[curVillageLevel].bronze.ToString();

        curFerText.text = ressources.fer.ToString();
        neededFerText.text = ressourcesPerLevel[curVillageLevel].fer.ToString();

        curObsidienneText.text = ressources.obsidienne.ToString();
        neededObsidienneText.text = ressourcesPerLevel[curVillageLevel].obsidienne.ToString();

        curAstateText.text = ressources.astate.ToString();
        neededAstateText.text = ressourcesPerLevel[curVillageLevel].astate.ToString();
    }

}


[System.Serializable]
public class Ressource
{
    public int nourriture = 0;
    public int bois = 0;
    public int pierre = 0;
    public int bronze = 0;
    public int fer = 0;
    public int obsidienne = 0;
    public int astate = 0;
}

[System.Serializable]
public class PrefabVariants
{
    public List<GameObject> prefabVariants = new List<GameObject>();
}
