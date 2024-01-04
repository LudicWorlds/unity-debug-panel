using UnityEngine;
using LudicWorlds;

public class Test : MonoBehaviour
{
    void Start()
    {
        Debug.Log("-> Test::Start()");
    }
    
    void OnEnable()
    {
        Debug.Log("-> Test::OnEnable()");
    }
    
    void OnDisable()
    {
        Debug.Log("-> Test::OnDisable()");
    }
    
    void OnDestroy()
    {
        Debug.Log("-> Test::OnDestroy()");
    }
}
