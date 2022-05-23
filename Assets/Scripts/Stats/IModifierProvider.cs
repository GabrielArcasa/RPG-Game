using System.Collections.Generic;

namespace BlackCat.Stats
{
    public interface IModifierProvider
    {
        // Get First VALUE , then , PERCENTAGE , em macac�s, ele pega primeiro o VALOR BONUS, e em segundo a Porcentagem BONUS
        IEnumerable<float> GetAdditiveModifier(Stat stat);
        IEnumerable<float> GetPercentageModifier(Stat stat);

    }
}
