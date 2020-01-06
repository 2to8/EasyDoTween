#if EasyDOTween_UI
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyDOTween.Animation.RectTransform
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/RectTransform/DOJumpAnchorPos")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.RectTransform))]
    public class DOJumpAnchorPos : EasyDOTween.Animation<UnityEngine.RectTransform>
    {
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Vector2 endValue;
        
        [UnityEngine.SerializeField()]
        private float jumpPower;
        
        [UnityEngine.SerializeField()]
        private int numJumps;
        
        [UnityEngine.SerializeField()]
        private bool snapping = false;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.RectTransform target, float duration)
        {
            return target.DOJumpAnchorPos(endValue, jumpPower, numJumps, duration, snapping);
        }
    }
}

#endif