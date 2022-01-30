using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string nextLevel;

    private bool byExit = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && byExit == true) 
        {
            loadNextLevel(nextLevel);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        text.enabled = true;
        byExit = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        text.enabled = false;
        byExit = true;
    }

    private void loadNextLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
