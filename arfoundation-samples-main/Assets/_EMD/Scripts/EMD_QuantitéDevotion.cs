using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EMD_QuantitéDevotion : MonoBehaviour
{
    public TMP_Text Devotion;
    public int IndexDevotion;
    private void Update()
    {
        Showressources(Devotion, IndexDevotion);
    }
    void Showressources(TMP_Text ressources, int value)
    {
        ressources.text = value.ToString();
    }
}
