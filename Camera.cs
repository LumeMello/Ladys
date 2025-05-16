using UnityEngine;
/// <summary>
/// include <UnityEngine.h>;
/// </summary>

public class Camera : MonoBehaviour
{
    public float[] Position;

    private void Start()
    {
        Position = new float[2];
        Position[0] = transform.position.x;
        Position[1] = transform.position.y;

    }

    private void Update()
    {
        gameObject.transform.position = new Vector3(Position[0], Position[1], transform.position.z);

    }
}
