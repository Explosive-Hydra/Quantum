using HarmonyLib;
using UnityEngine;

namespace Quantum.Video;

[HarmonyPatch(typeof(PlayerCamera))]
public static class HiddenHud
{
    public static bool Hidden;

    internal static void ApplyVisibility(PlayerCamera camera)
    {
        camera.mainCanvas.gameObject.SetActive(Hidden);
    }
}