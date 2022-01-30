using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string nextLevel;
    public GameObject player;

    private bool byExit = false;

    void Update()
    {
        if (player.GetComponent<ModeSwap>().getDarkModeOn() == true)
        {
            text.color = Color.black;
        }

        if (player.GetComponent<ModeSwap>().getDarkModeOn() == false)
        {
            text.color = Color.white;
        }

        if (Input.GetKeyDown(KeyCode.E) && byExit == true) 
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
