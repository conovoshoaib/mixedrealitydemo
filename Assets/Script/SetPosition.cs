using UnityEngine;

public class SetPosition : MonoBehaviour
{
   void OnEnable()
    {
       Invoke(nameof(SetPos),0.05f);
    }

    void SetPos(){
         transform.rotation = Quaternion.Euler(90f, 90f, 0f);
    }
}
