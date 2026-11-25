
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalizarJogo : MonoBehaviour
{
    public string nomeDaCena = "Prologo";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("prologo");
        }
    }
}
