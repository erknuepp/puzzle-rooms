using UnityEngine;

public class Zone : MonoBehaviour
{
    [SerializeField]
    private float width = .10f;

    // Start is called before the first frame update
    void Start()
    {
        var scale = transform.localScale;
        transform.localScale = new Vector3(width, scale.y, scale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
