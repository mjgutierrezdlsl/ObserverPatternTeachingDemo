using UnityEngine;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] Image _fillImage;
    [SerializeField] Bounce _bounceAnimation;

    public void OnDamageTaken(float currentHealth, float maxHealth)
    {
        _fillImage.fillAmount = currentHealth / maxHealth;
        _bounceAnimation.Click(0.95f);
    }
}
