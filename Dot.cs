using UnityEngine;

public class Dot : MonoBehaviour
{
    public enum Type
    {
        WhiteDot,
        BlackDot,
        WhiteLady,
        BlackLady
    }

    public Type type;

    public Sprite[] sprites;

    private SpriteRenderer spriteRenderer;

    public int actualPosition;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void ChangeSprite()
    {
        spriteRenderer.sprite = sprites[1];
    }

    
}
