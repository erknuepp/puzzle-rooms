using UnityEngine;
using UnityEngine.UI;

public class PipeDreamPuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int x = -10; x < 10; x+=2)
        {
            for (int y = 0; y < 10; y+=2)
            {
                CreateCube(x, y);
            }
        }
    }

    private static void CreateCube(int x, int y)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, 0);
        cube.name = $"X{x}Y{y}";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                var position = hit.transform.position;
                var rotation = hit.transform.rotation.z;
                Debug.Log($"X{position.x}:Y{position.y}");
                rotation = 90f;
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }
}
