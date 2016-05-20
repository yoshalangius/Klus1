using UnityEngine;
using System.Collections;

public class DoorTriggerScript : MonoBehaviour
{
    [SerializeField]
    private CollectKey Script;

    private bool _Activated = false;

    private float _Speed = 0.05f;


	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (_Activated == true)
        {
            transform.Translate(0, _Speed, 0);
        }
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && Script.HasKey == true)
        {
            _Activated = true;
            
        }
    }
}
