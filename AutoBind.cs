using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XLuaTest;

public class AutoBind 
{

    [MenuItem("AutoBind/Special Command %g")]
    public static void BuildFromUnityMenu()
    {
        GameObject twoSphere = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/CommonIcon.prefab", typeof(GameObject)) as GameObject;

        //GameObject twoCube = PrefabUtility.InstantiatePrefab(twoSphere) as GameObject;
        LuaBehaviour be = twoSphere.GetComponent<LuaBehaviour>();
        be.injections.Clear();
        foreach (Transform tran in twoSphere.transform)
        {
            Injection obj = new Injection();
            obj.name = tran.name;
            obj.value = tran.gameObject;
            be.injections.Add(obj);
        }

        Debug.Log("Done");
    }


}
