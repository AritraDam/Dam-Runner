using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardf;
    public float sideways;

    public Joystick joystick;
    float drx=0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(drx);
        drx = CrossPlatformInputManager.GetAxis("Horizontal")*sideways;
        
        rb.AddForce(drx*Time.deltaTime,0,0,ForceMode.VelocityChange);

        if(rb.position.y<0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(0,0,forwardf*Time.deltaTime);
    }
}
