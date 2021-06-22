using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public CoinPickupScript coinPickupScript;
    public PartCollectorManager partManagerScript;

    void Start()
    {
        coinPickupScript = GameObject.Find("CoinPickup").GetComponent<CoinPickupScript>();
        partManagerScript = GameObject.Find("PersistantObject").GetComponent<PartCollectorManager>();
    }

    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            coinPickupScript.playSound();
            partManagerScript.pickupCoin();
            Destroy(gameObject);
        }
    }


}
