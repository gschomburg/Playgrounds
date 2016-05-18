using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

    public GameObject vertFab;
    public Transform gridContainer;

    public Vector3 gridSize;
    public Vector3 gridsubDivisions;
    // Use this for initialization
    void Start () {
        buildGrid();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void buildGrid()
    {
        
        for (int gX = 0; gX <= gridsubDivisions.x; gX++)
        {
            for (int gY = 0; gY <= gridsubDivisions.y; gY++)
            {
                for (int gZ = 0; gZ <= gridsubDivisions.z; gZ++)
                {
                    Vector3 pos = new Vector3(
                        gX * (gridSize.x / gridsubDivisions.x),
                        gY * (gridSize.y / gridsubDivisions.y),
                        gZ * (gridSize.z / gridsubDivisions.z));
                    GameObject p = (GameObject)Instantiate(vertFab, pos, Quaternion.identity);
                    p.transform.parent = gridContainer;
                    //float s = Random.Range(sizMin, sizMax);
                    //p.transform.localScale = new Vector3(s, s, s);
                }
            }
        }
        gridContainer.position = new Vector3(-gridSize.x/2f, 0, -gridSize.z/2f);
    }
}
