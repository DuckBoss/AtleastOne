//!DOC
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using AtleastOne.ScriptableObjects.Cards;

//!na
namespace AtleastOne.Editors.Cards
{
    //!c
    /*
    Name: MakeCardSO
    Description: Editor class that creates the Card Scriptable Object for the game.
    */
    public class MakeCardSO
    {
        [MenuItem("Data/Create/Card")]
        //!s
        /*
        Name: CreateCardSO
        Description: Creates the Card scriptable object and saves it to the Assets/CardData directory.
        */
        public static void CreateCardSO()
        {
            CardSO asset = ScriptableObject.CreateInstance<CardSO>();

            AssetDatabase.CreateAsset(asset, "Assets/CardData/ScriptableObjects/NewCard.asset");
            AssetDatabase.SaveAssets();

            EditorUtility.FocusProjectWindow();

            Selection.activeObject = asset;
        }
        //#s
    }
    //#c
}
//#na