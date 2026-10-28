
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    public Sprite spriteBaixo;
    public Sprite spriteCima;
    public Sprite spriteEsquerda;
    public Sprite spriteDireita;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            spriteRenderer.sprite = spriteCima;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            spriteRenderer.sprite = spriteBaixo;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.sprite = spriteEsquerda;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.sprite = spriteDireita;
        }
    }
}
