using AreaCalculator.ProjectConstants;
using AreaCalculator.Strategies;
using System;

namespace AreaCalculator.Factories
{
    public class AreaStrategyFactory
    {
        public IAreaStrategy GetStrategy(Type figureType)
        {
            IAreaStrategy strategy = (IAreaStrategy)Type.GetType(string.Format(Constants.AREA_STRATEGY_PATH, figureType.Name)).
                GetConstructor(new Type[0] { }).
                Invoke(new object[] { });

            return strategy;
        }
    }
}