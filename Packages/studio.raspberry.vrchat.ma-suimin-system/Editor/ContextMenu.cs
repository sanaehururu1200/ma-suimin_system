using UnityEngine;
using UnityEditor;

namespace studio.raspberry.vrchat.ma_suimin_system
{
    public static class ContextMenu
    {
        const string baseMenuPath = "GameObject/RBS-SuiminSystem/";
        const string prefabPathBase = "Packages/studio.raspberry.vrchat.ma-suimin-system/Runtime/Prefabs/";
        const string japanesePrefabName = "RBS_Suimin(���{��).prefab";
        const string englishPrefabName = "RBS_Suimin(English).prefab";

        [MenuItem(baseMenuPath + "���{��ł̃Z�b�g�A�b�v(Japanese)")]
        public static void ApplyToAvatar_Japanese(MenuCommand command)
        {
            GameObject obj = UnityEditor.PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(prefabPathBase + japanesePrefabName)) as GameObject;
            if (obj != null)
            {
                Transform objTransform = obj.transform;
                objTransform.SetParent(Selection.activeTransform, false);
            }
        }

        [MenuItem(baseMenuPath + "Setup english version(�p��)")]
        public static void ApplyToAvatar_English(MenuCommand command)
        {
            GameObject obj = UnityEditor.PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(prefabPathBase + englishPrefabName)) as GameObject;
            if (obj != null)
            {
                Transform objTransform = obj.transform;
                objTransform.SetParent(Selection.activeTransform, false);
                UnityEditor.EditorUtility.SetDirty(obj);
                UnityEditor.EditorUtility.SetDirty(objTransform);
            }
        }
    }
}
