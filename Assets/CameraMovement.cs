using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    GameObject tower;

    public float moveSpeed = 5f;

    private float maxWidthX = 18f;
    private float smoothSpeed = 0.5f;

	// Use this for initialization
	void Start () {
        tower = GameObject.Find("Tower");
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        Camera.main.transform.LookAt(tower.transform);

        Vector3 currentPos = transform.position;

        if (Input.GetKey(KeyCode.A) && (currentPos.x > -maxWidthX))
        {
            Vector3 desiredPos = new Vector3(-moveSpeed * Time.deltaTime + currentPos.x, currentPos.y, currentPos.z);
            transform.position = Vector3.Lerp(currentPos, desiredPos, smoothSpeed);

        }
        else if (Input.GetKey(KeyCode.D) && (currentPos.x < maxWidthX))
        {
            Vector3 desiredPos = new Vector3(moveSpeed * Time.deltaTime + currentPos.x, currentPos.y, currentPos.z);
            transform.position = Vector3.Lerp(currentPos, desiredPos, smoothSpeed);

        }
        else if (Input.GetKey(KeyCode.W) && (currentPos.z < maxWidthX))
        {
            Vector3 desiredPos = new Vector3(currentPos.x, currentPos.y, currentPos.z + moveSpeed * Time.deltaTime);
            transform.position = Vector3.Lerp(currentPos, desiredPos, smoothSpeed);

        }
        else if (Input.GetKey(KeyCode.S) && (currentPos.z > -maxWidthX))
        {
            Vector3 desiredPos = new Vector3(currentPos.x, currentPos.y, currentPos.z + -moveSpeed * Time.deltaTime);
            transform.position = Vector3.Lerp(currentPos, desiredPos, smoothSpeed);
        }
    }
}
