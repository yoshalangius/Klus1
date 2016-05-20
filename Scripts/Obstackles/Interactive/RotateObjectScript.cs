using UnityEngine;
using System.Collections;

public class RotateObjectScript : MonoBehaviour
{
    [SerializeField]
    private float SpeedX;
    [SerializeField]
    private float SpeedY;
    [SerializeField]
    private float SpeedZ;
	
	void Update ()
    {
        RotateObject();
    }

    void RotateObject ()
    {
        transform.Rotate(new Vector3(SpeedX, SpeedY, SpeedZ) * Time.deltaTime);
    }
}
