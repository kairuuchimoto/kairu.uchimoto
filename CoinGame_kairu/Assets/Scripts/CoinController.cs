using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    public float speed;
    Vector3 posi;
    // Start is called before the first frame update
    void Start()
    {
        posi = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //if (this.transform.position.x > -1.2)
            this.transform.position += Vector3.left * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //if (this.transform.position.x < 1.2)
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }

        posi = this.transform.position;

        // プレハブを元にオブジェクトを生成する
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject instance = (GameObject)Instantiate(prefab, new Vector3(posi.x, posi.y - 2, posi.z), Quaternion.Euler(90,0,0));
        }
    }


}



