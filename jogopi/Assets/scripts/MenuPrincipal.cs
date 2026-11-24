
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string SampleScene = "Gameplay";

    public void IniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Saindo do jogo...");
    }
}
