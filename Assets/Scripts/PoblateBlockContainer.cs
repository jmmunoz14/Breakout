using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoblateBlockContainer : MonoBehaviour
{
    public GameObject gameObjectgameObject;

    // Start is called before the first frame update
    void Start()
    {
        int rows = 4;
        int cols = 15;
        var blockSize = gameObjectgameObject.GetComponent<BoxCollider2D>().size;

        float offSet = 0.685f;
        Vector3 startOffset = new Vector3(blockSize.x * -(cols / 2), 2, 0);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                GameObject block = Instantiate(gameObjectgameObject);

                block.transform.position =
                    new Vector3(j * blockSize.x,
                        (i * (blockSize.y / 2)) * offSet,
                        0) +
                    startOffset;

                switch (i)
                {
                    case (0):
                        block.GetComponent<SpriteRenderer>().color = Color.blue;
                        break;
                    case (1):
                        block.GetComponent<SpriteRenderer>().color = Color.green;
                        break;
                    case (2):
                        block.GetComponent<SpriteRenderer>().color = Color.yellow;
                        break;
                    case (3):
                        block.GetComponent<SpriteRenderer>().color = Color.red;

                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
