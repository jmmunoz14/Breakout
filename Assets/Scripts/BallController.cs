using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        setBall();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void setBall()
    {
        float dirX = Random.Range(-1.0f, 1.0f);

        Debug.Log("direx" + dirX);
        rb.velocity = new UnityEngine.Vector2(dirX * speed, 0.5f * speed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
    }
}
