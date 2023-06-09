using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

namespace StableDiffusion
{
    public class SDFunctions 
    {
        public static void ApplyTexture2dToOutputs(Texture2D[] textures, Renderer[] renderers, UnityEventTexture2D[] responseEvents)
        {
            if (renderers != null)
                for (int i = 0; i < textures.Length; i++)
                    if (renderers[i] != null)
                        renderers[i].material.mainTexture = textures[i];

            if (responseEvents != null)
                for (int i = 0; i < responseEvents.Length; i++)
                    responseEvents[i]?.Invoke(textures[i]);
        }

        public static void ApplyTexture2dToOutputs(Texture2D texture, Renderer renderer, UnityEventTexture2D responseEvent)
        {
            if (renderer != null)
                renderer.material.mainTexture = texture;

            if (responseEvent != null)
                responseEvent?.Invoke(texture);
        }

        public static string[] GetStringsFromTextures(Texture2D[] textures)
        {
            List<string> stringList = new List<string>();

            for (int i = 0; i < textures.Length; i++)
            {
                stringList.Add(Convert.ToBase64String(textures[i].EncodeToPNG()));
            }

            return stringList.ToArray();
        }
    }
}