using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI pTextScore;

    public void scorePoints(int scored)
    {
        score += scored;
        pTextScore.text = "Score: " + score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
