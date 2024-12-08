
using UnityEngine;
namespace as19
{
public class noveDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Mathf.Sin(Time.time*0.8f);
        transform.position += new Vector3(0,0,-a * Time.deltaTime * 5f); 
   }
}
}