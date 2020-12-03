using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class _TowerRessources : MonoBehaviour
{
    public TMP_Text foodRessources;
    public TMP_Text woodRessources;
    public TMP_Text stoneRessources;
    public TMP_Text bronzeRessources;
    public TMP_Text ironRessources;
    public TMP_Text obsidienneRessources;
    public TMP_Text astateRessources;

    public TMP_Text foodNecessary;
    public TMP_Text woodNecessary;
    public TMP_Text stoneNecessary;
    public TMP_Text bronzeNecessary;
    public TMP_Text ironNecessary;
    public TMP_Text obsidienneNecessary;
    public TMP_Text astateNecessary;

    public int testValue;
    public int testvalue2;

    // Start is called before the first frame update
    void Start()
    {
        Showressources(foodNecessary, testvalue2);
        Showressources(woodNecessary, testvalue2);
        Showressources(stoneNecessary, testvalue2);
        Showressources(bronzeNecessary, testvalue2);
        Showressources(ironNecessary, testvalue2);
        Showressources(obsidienneNecessary, testvalue2);
        Showressources(astateNecessary, testvalue2);

    }

    // Update is called once per frame
    void Update()
    {
        Showressources(foodRessources, testValue);
        Showressources(woodRessources, testValue);
        Showressources(stoneRessources, testValue);
        Showressources(bronzeRessources, testValue);
        Showressources(ironRessources, testValue);
        Showressources(obsidienneRessources, testValue);
        Showressources(astateRessources, testValue);
    }

    void Showressources(TMP_Text ressources, int value)
    {
        ressources.text = value.ToString();
    }
}   
