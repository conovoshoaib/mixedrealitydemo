using JetBrains.Annotations;
using UnityEngine;
namespace UnityEngine.XR.Templates.MR
{
public class UIManager : MonoBehaviour
{
     public GameObject Environment;

     public GameObject videoObject;
     public GameObject CubeObject;

    
    public void EnvironmentFunction(bool visible){
           
            Environment.SetActive(visible);
            Debug.Log("Environment " + visible);
   
    } 


    public void VideoFunction(bool visible){
           
               videoObject.SetActive(visible);
          
    } 

        public void CubeFunction(bool visible){
           
               CubeObject.SetActive(visible);
          
    } 

}
}