using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed= 50;
    public float directionalSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3 (Mathf.Clamp(gameObject.transform.position.x + moveHorizontal, - 2.5f, 2.5f), gameObject.transform.position.y,gameObject.transform.position.z), directionalSpeed *Time.deltaTime);
        GetComponent<Rigidbody>().velocity = Vector3.forward * playerSpeed * Time.deltaTime;
    }
}
