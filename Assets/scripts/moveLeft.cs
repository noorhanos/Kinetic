
using UnityEngine;
namespace as19
{
public class moveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Mathf.Sin(Time.time*0.8f);
        transform.position += new Vector3(-a * Time.deltaTime * 5f, 0, 0);  
    }
}
}