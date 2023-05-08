using UnityEngine;
using UnityEditor;

namespace StableDiffusion
{
    [CreateAssetMenu(fileName = "SD Config", menuName = "Stable Diffusion/Config File", order = 1)]
    public class StableDiffusionConfig : ScriptableObject
    {
        static StableDiffusionConfig _instance;
        public static StableDiffusionConfig instance
        {
            get
            {
                if (_instance == null)
                {
                    string [] guids = AssetDatabase.FindAssets("t:StableDiffusionConfig");
                    if (guids.Length >= 1)
                    {
                        _instance = AssetDatabase.LoadAssetAtPath<StableDiffusionConfig>(AssetDatabase.GUIDToAssetPath(guids[0]));

                        if (guids.Length > 1)
                            Debug.LogError("Too many stable diffusion config files! Loaded the first one found!");
                        return _instance;
                    }
                    else
                    {
                        Debug.LogError("Stable Diffusion config missing!");
                        return null;
                    }
                }
                return _instance;
            }
        }
        [Header("Login")]
        [Tooltip("URL address, without http:// at the start and without the backslash at the end")]
        [SerializeField] public string address;
        [SerializeField] public string username;
        [SerializeField] public string password;

        [Space(10)]

        //[Tooltip("By default, the stable diffusion image is imported upside down. Enable this to automatically rotate imported images by 180° so they are oriented correctly in unity space")]
        //[SerializeField] public bool fixRotation = true;
        

        //WIP
        #region Installed Extensions
        
        [Header("Extensions")]
        //public bool ABG_extension = false;
        [SerializeField] public bool stable_diffusion_webui_rembg = false;
        #endregion

        [InitializeOnLoadMethod]
        protected static void OnInitialize()
        {
            StableDiffusionConfig initialize = instance;
        }
    }
}