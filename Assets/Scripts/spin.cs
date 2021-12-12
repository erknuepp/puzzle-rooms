using UnityEngine;

public class spin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public Vector3 RotateAmount;
    private int _spinFactor = 0;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime * _spinFactor);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _spinFactor--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _spinFactor++;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key down");
            var color = Random.ColorHSV(0, 1);
            gameObject.GetComponent<Renderer>().material.color = color;
        }
    }
}