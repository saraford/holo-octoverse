using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawEdges : MonoBehaviour {

    public Material material; 

	// Use this for initialization
	void Start () {

        foreach (Transform siblings in this.gameObject.transform.parent.transform)
        {
            //TODO: don't try to draw a line from self to self

            GameObject edge = new GameObject("edge");
//            Instantiate(edge);
            edge.transform.parent = this.gameObject.transform;

            LineRenderer lineRenderer = edge.AddComponent<LineRenderer>();
            lineRenderer.SetPosition(0, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.transform.position.z));
            lineRenderer.SetPosition(1, new Vector3(siblings.transform.position.x, siblings.transform.position.y, siblings.transform.position.z));
            lineRenderer.startWidth = 0.0025f;
            lineRenderer.endWidth = 0.0025f;
            lineRenderer.material = material;

//            lineRenderer.transform.parent = edge.transform;
        }


    }
}
