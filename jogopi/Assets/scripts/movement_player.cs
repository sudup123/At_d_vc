
using Unity.VisualScripting;
using UnityEngine;

public class moviment_player : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 movimento = new Vector2(x, y);

        transform.Translate(movimento * velocidade * Time.deltaTime);
    }
}

