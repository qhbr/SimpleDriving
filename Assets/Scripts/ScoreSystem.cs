using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text ScoreText;
    [SerializeField] private float scoreMultiplier;

    private float score;

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;

        ScoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
