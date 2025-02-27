using UnityEngine;

public class Health : MonoBehaviour
{
   public int points = 5;

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Trap"))
      {
         Damage(1);

      }
   }
   
   //To remove some health points
   private void Damage(int value)
   {
      
      //HW:
      // DO NOT DESTROY
      //Move the player to start and reset points to 5
      
      points = points - value;
      if (points < 1)
      {
         Destroy(gameObject);
      }
   }

}
