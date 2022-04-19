using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlockController : MonoBehaviour
{
    private GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("" + other.gameObject.tag);
        if (other.gameObject.tag == "Ball")
        {
            gm.GetComponent<GameManager>().scorePoints(10);

            Destroy(this.gameObject);
        }
    }
}
