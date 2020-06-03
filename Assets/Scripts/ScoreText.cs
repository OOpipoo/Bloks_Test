using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;

    private void Start() 
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        GameController.OnCubeSpawned += GameController_OnCubeSpawned;
    }
    private void OnDestroy()
    {
        GameController.OnCubeSpawned -= GameController_OnCubeSpawned;
    }
    private void GameController_OnCubeSpawned()
    {
        score++;
        text.text = "Score:" + score;
    }
}
