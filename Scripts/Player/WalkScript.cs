using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Animator anim;

    int SpeedHash = Animator.StringToHash("Speed");

    private float speed = 0.1f;

    private bool Speed = false;

	// Use this for initialization
	void Start ()
    {

        anim = GetComponent<Animator>();
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Speed);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetTrigger(SpeedHash);
            Speed = true;
            transform.Translate(speed,0,0);
            
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            
            Speed = false;
            anim.ResetTrigger(SpeedHash);
           

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            anim.SetTrigger(SpeedHash);
            Speed = true;
            transform.Translate(-speed, 0, 0);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            
            Speed = false;
            anim.ResetTrigger(SpeedHash);


        }


    }
}
