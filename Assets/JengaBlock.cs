using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaBlock : MonoBehaviour {

    public Material defaultMaterial;

    [SerializeField]
    private bool isSelected = false;

    public void SetSelected() {
        this.isSelected = true;
    }

    public void Move()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 10000);
    }

    void OnMouseOver() 
    {   
        if (!isSelected)
            GetComponent<Renderer>().material.color = Color.red;
    }

    void OnMouseExit()
    {
        if (!isSelected)
            GetComponent<Renderer>().material = defaultMaterial;


    }
}
