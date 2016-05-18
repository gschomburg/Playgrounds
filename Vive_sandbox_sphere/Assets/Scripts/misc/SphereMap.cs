using UnityEngine;
using System.Collections;

public class SphereMap : MonoBehaviour {
    public GameObject particleObj;
    public GameObject particleConnectorObj;
    public Transform target;
    public float particleDensity=0.5f;
    public float radius = 2;
    public float sizMin = 0.01f;
    public float sizMax = 0.1f;
    // Use this for initialization
    void Start () {
	    //build map
        for(int i=0; i< particleDensity * 1000; i++)
        {
            //float _x= Random.Range(-radius, radius);
            Vector3 pos = Random.onUnitSphere * radius;
            GameObject p = (GameObject)Instantiate(particleObj, pos, Quaternion.identity);
            p.transform.parent = target;
            float s = Random.Range(sizMin, sizMax);
            p.transform.localScale = new Vector3(s,s,s);
            
            //p.transform.localScale = new Vector3(Random.Range(sizMin, sizMax), Random.Range(sizMin, sizMax), Random.Range(sizMin, sizMax*2));
            p.transform.LookAt(target);

            GameObject c = (GameObject)Instantiate(particleConnectorObj, pos, Quaternion.identity);
            c.transform.parent = target;
            c.transform.localScale = new Vector3(.02f, .02f, .02f);
            c.transform.LookAt(target);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
