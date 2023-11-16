using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void RestartLevel() => 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
