using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace pfc.EditorPatching.Samples
{
    public class DeepLinkSample : MonoBehaviour
    {
#if UNITY_EDITOR
        [DeepLink]
        private static bool LogDeepLink(string url)
        {
            Debug.Log("[Deep Link] Received: " + url);
            return false;
        }

        [DeepLink(RegexFilter = @"com.unity3d.kharma:custom\/(.*)")]
        private static bool CaptureCustomData(string data)
        {
            Debug.Log("[Deep Link] Data: " + data);
            return true;
        }
        
        [DeepLink(RegexFilter = @"com.unity3d.kharma:selected-sample\/(.*)")]
        private static bool CaptureCustomDataSelected(string data)
        {
            var objects = GameObject.FindObjectsOfType<DeepLinkSample>();
            foreach (var obj in objects)
            {
                if (data.StartsWith(obj.name))
                    obj.DeepLinkCalled(data);
            }
            return true;
        }
#endif
        
        private void DeepLinkCalled(string data)
        {
            Debug.Log("[deep Link] Received: " + data + " on object " + name, this);
        }
    }
}
