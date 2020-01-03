using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    [SerializeField] private Button Play;
    void Start()
    {
        Play.onClick.AddListener(PlayGame);
    }

    // Update is called once per frame
  private void PlayGame()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}
