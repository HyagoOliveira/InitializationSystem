using UnityEngine;
using System.Threading.Tasks;

namespace OneM.Game.SceneSystem
{
    /// <summary>
    /// Instantiates the "Dependencies" Prefab (via Addressables or Resources) into 
    /// the <b>DontDestroyOnLoad Scene</b> when the game enters in Play mode.
    /// </summary>
    /// <remarks>
    /// It's important to name the Prefab using <see cref="PREFAB_NAME"/> value 
    /// and set it as an addressable using the same name.
    /// <para>
    /// If you are not using the Addressables package, place the prefab into a Resources folder.
    /// </para>
    /// </remarks>
    public static class DependencyInstantiater
    {
        /// <summary>
        /// Event fired when all dependencies are instantiated.
        /// </summary>
        public static event System.Action OnInstantiated;

        public static bool IsInstantiating { get; private set; }
        public static readonly string PREFAB_NAME = "Dependencies";

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static async void Instantiate()
        {
            var showLog = !Application.isEditor;
            if (showLog) Debug.Log("Instantiating Dependencies...");

            IsInstantiating = true;

            var instance = await LoadAsync();
            instance.name = PREFAB_NAME;
            Object.DontDestroyOnLoad(instance);

            IsInstantiating = false;

            OnInstantiated?.Invoke();
            if (showLog) Debug.Log("All dependencies are instantiated successfully.");
        }

        private static async Task<GameObject> LoadAsync()
        {
#if HAS_ADDRESSABLES
            return await UnityEngine.AddressableAssets.Addressables.InstantiateAsync(PREFAB_NAME).Task;
#else
            // Loading using Resources
            return Object.Instantiate(Resources.Load<GameObject>(PREFAB_NAME));
#endif
        }
    }
}