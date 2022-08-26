using UnityEngine;

public class ScaleToFitScreen : MonoBehaviour
{
    private SpriteRenderer _sr;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();

        // world height is always camera's orthographicSize * 2
        if (Camera.main is null) return;
        var worldScreenHeight = Camera.main.orthographicSize * 2;

        // world width is calculated by diving world height with screen heigh
        // then multiplying it with screen width
        var worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        // to scale the game object we divide the world screen width with the
        // size x of the sprite, and we divide the world screen height with the
        // size y of the sprite
        var sprite = _sr.sprite;
        transform.localScale = new Vector3(
            worldScreenWidth / sprite.bounds.size.x,
            worldScreenHeight / sprite.bounds.size.y, 1);
    }

} // class