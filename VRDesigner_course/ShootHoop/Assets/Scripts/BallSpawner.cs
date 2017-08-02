using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject BallPrefab;
    public float speed = 10f;

    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(BallPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;
        }
	
	}
}
