using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var laserPositionX = this.gameObject.transform.GetChild(0).position.x;
            var zonePositionX = this.gameObject.transform.GetChild(1).position.x;
            var zoneLocalScaleX = this.gameObject.transform.GetChild(1).localScale.x;
            if (laserPositionX > zonePositionX - (zoneLocalScaleX / 2) && laserPositionX < zonePositionX + (zoneLocalScaleX / 2))
            {
                Debug.Log("In");
                score++;
                Debug.Log(score);
            }
            else
            {
                Debug.Log("Out");
            }
        }
    }
}
