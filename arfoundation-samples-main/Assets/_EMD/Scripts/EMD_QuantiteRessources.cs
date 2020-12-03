using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EMD_QuantiteRessources : MonoBehaviour
{
    public TMP_Text Bois;
    public TMP_Text Nourriture;
    public TMP_Text Pierre;
    public TMP_Text Bronze;
    public TMP_Text Fer;    
    public TMP_Text Obsidienne;
    public TMP_Text Astate;
    public int IndexWood;
    public int IndexFood;
    public int IndexStone;
    public int IndexBronze;
    public int IndexIron;    
    public int IndexObsidian;
    public int IndexAstate;

    private void Update()
    {
        Showressources(Bois, IndexWood);
        Showressources(Nourriture, IndexFood);
        Showressources(Pierre, IndexStone);
        Showressources(Bronze, IndexBronze);
        Showressources(Fer, IndexIron);
        Showressources(Obsidienne, IndexObsidian);
        Showressources(Astate, IndexAstate);
    }
    void Showressources(TMP_Text ressources, int value)
    {
        ressources.text = value.ToString();
    }
}
