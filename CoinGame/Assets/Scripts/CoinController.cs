using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public float speed = 1.0f;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab, new Vector3(transform.position.x, transform.position.y - 3.0f, transform.position.z), Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x < 7) 
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x > -7) 
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
        
    

