using UnityEngine;

public class SquareToMouse : MonoBehaviour
{
    public Transform CubeTransform;
    public Vector2 PosisiKlik;
    // Update is called once per frame
    void Update()
    {
        //Geser object mengikuti arah mouse
        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, worldMousePosition, .1f);

        //Geser object mengikuti arah klik
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        CubeTransform.position = Vector2.MoveTowards(CubeTransform.position, PosisiKlik, .1f);
    }
}
