using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //public PlayerController player;
    private Rigidbody enemyRb;
    public float speed = 2f;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       // player.GetComponent<PlayerController>();
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionalLook = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(directionalLook * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        player.transform.localScale = new Vector3(2, 2, 2);
    }
}
