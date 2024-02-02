using UnityEngine;
using LudicWorlds;

public class Test : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("-> Test::Awake()");
    }

    void OnEnable()
    {
        Debug.Log("-> Test::OnEnable()");
    }

    void Start()
    {
        Debug.Log("-> Test::Start()");
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
