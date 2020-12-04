using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_RessourceAdder : MonoBehaviour
{
    KLD_GameManager gameManager;

    public enum RessourceType
    {
        NOURRITURE,
        BOIS,
        PIERRE,
        BRONZE,
        FER,
        OBSIDIENNE,
        ASTATE
    }

    public RessourceType ressourceToAdd;

    [SerializeField]
    Vector2Int minMaxQuantity = new Vector2Int(3, 6);

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<KLD_GameManager>();
    }

    private void Update()
    {
        if (detectClick())
        {
            addRessource();
            Destroy(gameObject);
        }
    }


    bool detectClick()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    return true;
                }
            }
        }
        return false;
    }

    void addRessource()
    {
        switch (ressourceToAdd)
        {
            case RessourceType.NOURRITURE:
                gameManager.addNourriture(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            case RessourceType.BOIS:
                gameManager.addBois(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            case RessourceType.PIERRE:
                gameManager.addPierre(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            case RessourceType.BRONZE:
                gameManager.addBronze(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            case RessourceType.FER:
                gameManager.addFer(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            case RessourceType.OBSIDIENNE:
                gameManager.addObsidienne(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            case RessourceType.ASTATE:
                gameManager.addAstate(Random.Range(minMaxQuantity.x, minMaxQuantity.y + 1));
                return;
            default:
                return;
        }
    }

}
