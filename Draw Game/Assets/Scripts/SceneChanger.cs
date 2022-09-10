using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void TomatoLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void CherryLevel()
    {
        SceneManager.LoadScene(2);
    }
}
