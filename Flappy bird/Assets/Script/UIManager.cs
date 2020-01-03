using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Sorce;
    // Update is called once per frame
    void Update()
    {
        
        Sorce.text = Bird.birdInstant.sorce.ToString();      
    }
}
