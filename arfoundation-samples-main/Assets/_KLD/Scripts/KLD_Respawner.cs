using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KLD_Respawner : MonoBehaviour
{

    [SerializeField]
    Vector2 minMaxTimeToWait = new Vector2(10f, 30f);

    [SerializeField]
    GameObject objToSpawn;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObj());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator spawnObj()
    {
        yield return new WaitForSeconds(Random.Range(minMaxTimeToWait.x, minMaxTimeToWait.y));
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
