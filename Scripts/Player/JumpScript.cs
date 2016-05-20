using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour
{
    [SerializeField]
    private  Rigidbody2D rb;

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private float Strength = 150f;
    public bool Grounded = true;

    int JumpHash = Animator.StringToHash("Grounded");

    void Start ()
    {

        anim = GetComponent<Animator>();

        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveVertical, 0f, 0f);
    }
	
	
	void Update ()
    {
        if (Grounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * Strength);
                Debug.Log(" A.D.I.D.A.S.");
            }
        }
      
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "ground")
        {
            anim.SetTrigger(JumpHash);
            Grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "ground")
        {
            anim.ResetTrigger(JumpHash);

            Grounded = false;
        }
    }
}
