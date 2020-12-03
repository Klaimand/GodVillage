using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_GameManager : MonoBehaviour
{
    [Header("Ressources"), SerializeField]
    Ressource[] ressources;


    [Space(15), SerializeField]
    int maxDevotion;
    float curDevotion;

    [Space(10), SerializeField]
    int curVillageLevel;

    [SerializeField]
    LevelRessource[] ressourcesPerLevel;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


[System.Serializable]
public class Ressource
{
    public enum RessourceType
    {
        NOURRITURE, //   0
        BOIS, //         1
        PIERRE, //       2
        BRONZE, //       3
        FER, //          4
        OBSIDIENNE, //   5
        ASTATE //        6
    }

    public RessourceType ressourceType;
    public int curNumber;
}

[System.Serializable]
public class LevelRessource
{
    public Ressource[] ressourcesNeeded = new Ressource[7];
}
