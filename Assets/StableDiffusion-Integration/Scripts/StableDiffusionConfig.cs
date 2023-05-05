using UnityEngine;

namespace StableDiffusion
{
    [CreateAssetMenu(fileName = "SD Config", menuName = "Stable Diffusion/Config File", order = 1), ExecuteInEditMode]
    public class StableDiffusionConfig : ScriptableObject
    {
        private static StableDiffusionConfig _instance;
        public static StableDiffusionConfig instance { get { return _instance; } private set { _instance = value; } }

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
        public bool stable_diffusion_webui_rembg = false;
        #endregion

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Debug.LogError("Multiple Stable Diffusion Config files detected! Only one should exist in the project files!");
            }
        }

        private void OnValidate()
        {
            Awake();
        }

        private void Reset()
        {
            instance = null;
            Awake();
        }

        private void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }
    }
}