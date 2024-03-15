using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject _canvas;
    private void Update()
    {
        if (DestroyOutOfBounds.animalsCounter == 10)
        {
            StartCoroutine(GameOver());
            _canvas.SetActive(true);
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 0;
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
        DestroyOutOfBounds.animalsCounter = 0;
    }
}
