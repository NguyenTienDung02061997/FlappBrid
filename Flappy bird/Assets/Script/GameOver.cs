using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Button PlayAgian;
    [SerializeField] private Button Home;
    [SerializeField] private Text Sorce;
    [SerializeField] private Text HighSorce;

    void Start()
    {
        PlayAgian.onClick.AddListener(LoadGameAgian);
        Home.onClick.AddListener(LoadGameHome);
    }

    private void Update()
    {
        if (int.Parse(Sorce.text) > int.Parse(HighSorce.text))
        {
            HighSorce.text = Sorce.text;
        }
    }
    private void LoadGameAgian()
    {
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
    private void LoadGameHome()
    {
        SceneManager.LoadScene("Home", LoadSceneMode.Single);
    }

}
