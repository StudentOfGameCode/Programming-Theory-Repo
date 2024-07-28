using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("shape main scene");
    }
}

