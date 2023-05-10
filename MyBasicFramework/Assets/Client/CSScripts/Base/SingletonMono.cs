using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SingletonMono<T> : MonoBehaviour where T:MonoBehaviour
{
    private static T instance;
    public static T GetInstance()
    {
        if (instance == null)
        {
            GameObject obj = new GameObject();
            obj.name = typeof(T).ToString();
            instance = obj.AddComponent<T>();
        }
        return instance;
    }
/*    //�̳���MonoBehaviour��Ҫȷ��Scene�ϵ�Ψһ��
    protected virtual void Awake()
    {
        instance = this as T;
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {
    }
    // Update is called once per frame
    protected virtual void Update()
    {
        
    }*/
}
