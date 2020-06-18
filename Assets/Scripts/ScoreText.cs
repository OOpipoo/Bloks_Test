using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreText : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI text; 
    private void Start() 
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        GameController.OnCubeSpawned += GameController_OnCubeSpawned;
    }
    
    private void OnDestroy()
    {
        GameController.OnCubeSpawned -= GameController_OnCubeSpawned;
    }
    public void GameController_OnCubeSpawned()
    {
        score++;
        text.text = "Score: " + score;
    }
}
