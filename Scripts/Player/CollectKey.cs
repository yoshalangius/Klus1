using UnityEngine;
using System.Collections;

public class CollectKey : MonoBehaviour
{

    public bool HasKey = false;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            HasKey = true;
            other.gameObject.SetActive(false);
            
            Debug.Log("i picked up the pick up");
            
        }
    }
}
