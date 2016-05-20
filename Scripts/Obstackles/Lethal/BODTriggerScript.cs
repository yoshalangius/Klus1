using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BODTriggerScript : MonoBehaviour
{
    public delegate void Triggered(bool isTriggered);

    [SerializeField]
    private GameObject MainMenuButton;

    [SerializeField]
    private Text Death_text;

    [SerializeField]
    private GameObject DeathCam;
    [SerializeField]
    private GameObject MainCam;




    private bool isTriggered = false;

    private Triggered isTrigger;

    void Start ()
    {
       
	}
	
	
	void Update ()
    {
       
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BOD")
        {
            MainCam.SetActive(false);
            DeathCam.SetActive(true);
            MainMenuButton.SetActive(true);


            
            isTriggered = true;

            
            

            Death_text.text = "You Are Dead";

            Destroy(this.gameObject);

            


            
        }
    }
}
