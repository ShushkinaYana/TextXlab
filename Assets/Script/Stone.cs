using UnityEngine;


public class Stone : MonoBehaviour
{
   
private void OnCollisionEnter(Collision other)
{
    Debug.Log(other.gameObject.name, this);
}

}
