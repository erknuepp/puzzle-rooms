using UnityEngine;

public class Zone : MonoBehaviour
{
    [SerializeField]
    private float xScale = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        var scale = transform.localScale;
        transform.localScale = new Vector3(xScale, scale.y, scale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
