//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyDOTween.Animation.Transform
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Transform/DOPunchScale")]
    public class DOPunchScale : EasyDOTween.Animation<UnityEngine.Transform>
    {
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Vector3 punch;
        
        [UnityEngine.SerializeField()]
        private int vibrato = 10;
        
        [UnityEngine.SerializeField()]
        private float elasticity = 1F;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.Transform target, float duration)
        {
            return target.DOPunchScale(punch, duration, vibrato, elasticity);
        }
    }
}
