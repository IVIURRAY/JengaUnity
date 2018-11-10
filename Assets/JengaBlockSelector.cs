using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaBlockSelector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        HighlightSelectedBlock();
    }

    private static void HighlightSelectedBlock()
    {
        RaycastHit hit;
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "JengaBlock")
                {
                    JengaBlock jengaBlock = hit.collider.GetComponent<JengaBlock>();
                    jengaBlock.SetSelected();
                    jengaBlock.GetComponent<Renderer>().material.color = Color.blue;
                    jengaBlock.Move();
                }
            }
        }
    }
}
