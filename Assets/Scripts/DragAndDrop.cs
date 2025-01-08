
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Transform pointer;

    [Header("Selecciona para saber sobre que ejes mover")]
    public bool x;
    public bool y;
    public bool z;

    public void Drag()
    {
        float newX = x ? pointer.position.x : transform.position.x;
        float newY = y ? pointer.position.y : transform.position.y;
        float newZ = z ? pointer.position.z : transform.position.z;

        transform.position = new Vector3(newX, newY, newZ);
    }
}
