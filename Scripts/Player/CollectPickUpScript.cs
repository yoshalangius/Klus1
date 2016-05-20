using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectPickUpScript : MonoBehaviour
{

    private int _count;

    public Text countText;

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
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            _count = _count + 1;
            Debug.Log("i picked up the pick up");
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + _count.ToString();
        if (_count >= 12)
        {
            
        }
    }
}
