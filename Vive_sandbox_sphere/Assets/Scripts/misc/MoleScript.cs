using UnityEngine;
using System.Collections;

public class MoleScript : MonoBehaviour {
    public float force=200f;
    public float upY = 1f;
    public float forceUp=1f;
    public bool popped = false;


    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Random.Range(0f, 100f) > 99.8f)
        {
            pop();
        }
        if (popped)
        {
            //apply force
            rb.AddForce(transform.up * forceUp);
        }
	}
    void OnCollisionEnter(Collision collision)
    {
        popped = false;
    }

    public void pop()
    {
        // transform.position = new Vector
        // transform.position = new Vector3(transform.position.x, upY, transform.position.z);
        popped = true;
    }

}
