using UnityEngine;

namespace Snake_MVVM.View
{
    public class SnakeHeadV : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.GetComponent<FoodV>())
            {
                Debug.Log("You lose");
            }
        }
    }
}
