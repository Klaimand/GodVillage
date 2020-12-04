using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMD_ButtonGestion : MonoBehaviour
{
    public void TremblementButton()
    {
        gameObject.GetComponent<EMD_Tremblement>().enabled = true;
    }
    /*public void EclairButton()
    {
        gameObject.GetComponent<EMD_Eclair>().enabled = true;
    }
    public void MétéoriteButton()
    {
        gameObject.GetComponent<EMD_Meteorite>().enabled = true;
    }*/
}
