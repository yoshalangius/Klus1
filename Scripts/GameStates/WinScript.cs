using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinScript : MonoBehaviour
{

    [SerializeField]
    private Text Win_text;
    [SerializeField]
    private GameObject MainMenuButton;



    void Awake()
    {
        MainMenuButton.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            MainMenuButton.SetActive(true);

            Win_text.text = "You Are Win";
        }

    }

}
