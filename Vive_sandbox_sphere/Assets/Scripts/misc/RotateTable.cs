using UnityEngine;
using System.Collections;

public class RotateTable : MonoBehaviour {
    public float amount = 50f;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;
      
        rb.AddTorque(transform.up * v);
    }
}
