using UnityEngine;
using System.Collections;

public class OnCollisionPickup : MonoBehaviour {

    public GameObject Player;
    public GameObject Inventory;

    void OnCollisionEnter(Collision a)
    {
        if (a.gameObject.tag == "item")
        {
            Inventory.GetComponent<PlayerInventory>().Items.Add(gameObject);
            Object.DontDestroyOnLoad(gameObject);
            gameObject.transform.parent = a.transform;
            gameObject.GetComponent < Rigidbody > ;
        }
    }


}
