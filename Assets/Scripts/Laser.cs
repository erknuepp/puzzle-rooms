using UnityEngine;

public class Laser : MonoBehaviour
{
    private const int inverter = -1;
    private float direction;

    [SerializeField]
    private int bound = 2;
    [SerializeField]
    private float rate = .01f;
    [SerializeField]
    private float tolerance = .2f;

    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        if(Mathf.Abs(pos.x) > bound - tolerance && Mathf.Abs(pos.x) < bound + tolerance)
        {
            direction *= inverter;
        }

        transform.position = new Vector3(pos.x + (rate * direction), pos.y, pos.z);
    }
}