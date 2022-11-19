
using UnityEngine;

public class BlockDelete : MonoBehaviour
{
   
    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
